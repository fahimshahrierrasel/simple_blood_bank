using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Blood_Bank_Management
{
    public class BankController
    {
        private readonly DbConnection _dbConnection;

        public BankController()
        {
            _dbConnection = new DbConnection();
        }

        public List<String> GetBloodGroups()
        {
            _dbConnection.Command.CommandText = "Select * From BloodGroup";
            _dbConnection.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(_dbConnection.Command);
            _dbConnection.Connection.Close();

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "BloodGroup");
            DataTable bloodGroupTable = dataSet.Tables["BloodGroup"];

            List<String> bloodGroups = new List<string>();
            
            foreach (DataRow dr in bloodGroupTable.Rows)
            {
                bloodGroups.Add(dr["bgName"].ToString());
            }

            return bloodGroups;
        }

        public int GetAvailablePacksForBloodGroup(int bloodgId)
        {
            _dbConnection.Command.CommandText = "Select quantity From Storage Where bgId = @BloodID";
            _dbConnection.Command.Parameters.Add("@BloodID", SqlDbType.Int).Value = bloodgId;
            _dbConnection.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(_dbConnection.Command);
            _dbConnection.Connection.Close();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Storage");
            DataTable stroageTable = dataSet.Tables["Storage"];
            int totalAvailablePack = Int32.Parse(stroageTable.Rows[0]["quantity"].ToString());
            _dbConnection.ClearCommandText();
            return totalAvailablePack;
        }

        public DataTable GetStorageInformation()
        {
            _dbConnection.Command.CommandText = "SELECT BloodGroup.bgName as 'Blood Group', Storage.quantity as 'Quantity' From BloodGroup, Storage WHERE Storage.bgId = BloodGroup.bgId";
            _dbConnection.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(_dbConnection.Command);
            _dbConnection.Connection.Close();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public bool CanReciptBlood(int totalPack, int bloodGroupId)
        {
            if (GetAvailablePacksForBloodGroup(bloodGroupId) - totalPack >= 0)
            {
                UpdateStorageForBloodGroup(-totalPack, bloodGroupId);
                return true;
            }
            return false;
        }
        
        public bool UpdateStorageForBloodGroup(int qunatity, int bloodGroupId)
        {

            int updatedQuantity = GetAvailablePacksForBloodGroup(bloodGroupId) + qunatity;
            
            try
            {
                _dbConnection.Command.CommandText =
                    "UPDATE Storage SET quantity = @QUANTITY WHERE bgId = @BGID";
                _dbConnection.Command.Parameters.Add("@QUANTITY", SqlDbType.Int).Value = updatedQuantity;
                _dbConnection.Command.Parameters.Add("@BGID", SqlDbType.Int).Value = bloodGroupId;
                _dbConnection.Connection.Open();
                _dbConnection.Command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
                return false;
            }
            finally
            {
                _dbConnection.Connection.Close();
            }
            return true;
        }
    }
}
