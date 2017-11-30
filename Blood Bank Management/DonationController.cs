using System;
using System.Data;
using System.Data.SqlClient;

namespace Blood_Bank_Management
{
    public class DonationController
    {
        private readonly DbConnection _dbConnection;

        public DonationController()
        {
            _dbConnection = new DbConnection();
        }

        // Insert Donor info to database
        public bool InsertDonationToDb(int donorId, int quantity, DateTime donationDate)
        {
            try
            {
                _dbConnection.Command.CommandText =
                    "Insert into Donation (DonorId, quantity, date) Values(@DID, @Quantity, @CurrentDate)";
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
        
        public DataTable GetDonationInformation()
        {
            _dbConnection.Command.CommandText = "SELECT Donation.donationId, Donor.name, Donation.quantity, Donation.date FROM Donation, Donor WHERE Donation.DonorId = Donor.DonorId";
            _dbConnection.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(_dbConnection.Command);
            _dbConnection.Connection.Close();
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public double DiferenceBetweenLastDonation(String lastDonationDateString)
        {
            if (lastDonationDateString.Length > 0)
            {
                DateTime lastDonationDate = DateTime.Parse(lastDonationDateString);
                return (lastDonationDate.Date - DateTime.Now.Date).TotalDays;
            }
            return 91.0;
        }
    }
}
