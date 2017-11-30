using System;
using System.Data;
using System.Data.SqlClient;

namespace Blood_Bank_Management
{
    class RecipitionController
    {
        private readonly DbConnection _dbConnection;

        public RecipitionController()
        {
            _dbConnection = new DbConnection();
        }

        // Insert Donor info to database
        public bool InsertRecipitionToDb(int donorId, int quantity, DateTime donationDate)
        {
            try
            {
                _dbConnection.Command.CommandText =
                    "Insert into Reciption (DonorId, quantity, date) Values(@DID, @Quantity, @CurrentDate)";
                _dbConnection.Command.Parameters.Add("@DID", SqlDbType.Int).Value = donorId;
                _dbConnection.Command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                _dbConnection.Command.Parameters.Add("@CurrentDate", SqlDbType.Date).Value = donationDate.Date;
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

        public DataTable GetRecipientInformation()
        {
            _dbConnection.Command.CommandText = "SELECT Reciption.receptionId, Donor.name, Reciption.quantity, Reciption.date FROM Reciption, Donor WHERE Reciption.DonorId = Donor.DonorId";
            _dbConnection.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(_dbConnection.Command);
            _dbConnection.Connection.Close();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
