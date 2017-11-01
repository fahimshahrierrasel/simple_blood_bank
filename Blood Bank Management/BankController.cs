using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public class BankController
    {
        private DbConnection dbConnection;

        public BankController()
        {
            dbConnection = new DbConnection();
        }

        public List<String> GetBloodGroups()
        {
            dbConnection.Command.CommandText = "Select * From BloodGroup";
            dbConnection.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(dbConnection.Command);
            dbConnection.Connection.Close();

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
            dbConnection.Command.CommandText = "Select quantity From Storage Where bgId = @BloodID";
            dbConnection.Command.Parameters.Add("@BloodID", SqlDbType.Int).Value = bloodgId;
            dbConnection.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(dbConnection.Command);
            dbConnection.Connection.Close();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Storage");
            DataTable stroageTable = dataSet.Tables["Storage"];
            int totalAvailablePack = Int32.Parse(stroageTable.Rows[0]["quantity"].ToString());
            dbConnection.ClearCommandText();
            return totalAvailablePack;
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
            
            // UPDATE CustTest SET CustID = @p1 , CustName = @p2 WHERE ( CustID = @p3 AND CustName = @p4 )
            try
            {
                dbConnection.Command.CommandText =
                    "UPDATE Storage SET quantity = @QUANTITY WHERE bgId = @BGID";
                dbConnection.Command.Parameters.Add("@QUANTITY", SqlDbType.Int).Value = updatedQuantity;
                dbConnection.Command.Parameters.Add("@BGID", SqlDbType.Int).Value = bloodGroupId;
                dbConnection.Connection.Open();
                dbConnection.Command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
                return false;
            }
            finally
            {
                dbConnection.Connection.Close();
            }
            return true;
        }
    }
}
