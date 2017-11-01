using System;
using System.Data;

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
    }
}
