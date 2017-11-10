using System;
using System.Data;
using System.Data.SqlClient;

namespace Blood_Bank_Management
{
    class DonationController
    {
        private DbConnection dbConnection;

        public DonationController()
        {
            dbConnection = new DbConnection();
        }

        // Insert Donor info to database
        public bool InsertDonationToDb(int donorId, int quantity, DateTime donationDate)
        {
            try
            {
                dbConnection.Command.CommandText =
                    "Insert into Donation (DonorId, quantity, date) Values(@DID, @Quantity, @CurrentDate)";
                dbConnection.Command.Parameters.Add("@DID", SqlDbType.Int).Value = donorId;
                dbConnection.Command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                dbConnection.Command.Parameters.Add("@CurrentDate", SqlDbType.Date).Value = donationDate.Date;
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
        
        public DataTable GetDonationInformation()
        {
            dbConnection.Command.CommandText = "SELECT Donation.donationId, Donor.name, Donation.quantity, Donation.date FROM Donation, Donor WHERE Donation.DonorId = Donor.DonorId";
            dbConnection.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(dbConnection.Command);
            dbConnection.Connection.Close();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
