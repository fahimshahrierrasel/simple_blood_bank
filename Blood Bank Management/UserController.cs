using System;
using System.Data;

namespace Blood_Bank_Management
{

    class UserController
    {
        private DbConnection dbConnection;

        public UserController()
        {
            dbConnection = new DbConnection();
        }


        // Get Donor and DonorDonationLog info from DB
        // Select Donor.DonorID, Donor.name, Donor.dob, Donor.bloodGroup, Donor.weight, Donor.mobileNo, Donor.address, DonorDonationLog.lastDonationDate From Donor, DonorDonationLog where Donor.DonorId = DonorDonationLog.DonorId

        // Insert Donor info to database
        public bool InsertDonorToDb(string userName, DateTime dob, int bloodGroup, int weight, string mobileNumber, string address)
        {
            try
            {
                dbConnection.Command.CommandText =
                        "Insert into Dono Values (@UserName, @Dob, @BloodGroup, @Weight, @MobileNumber, @Address)";
                dbConnection.Command.Parameters.Add("@Username", SqlDbType.VarChar).Value = userName;
                dbConnection.Command.Parameters.Add("@Dob", SqlDbType.Date).Value = dob.Date;
                dbConnection.Command.Parameters.Add("@BloodGroup", SqlDbType.Int).Value = bloodGroup;
                dbConnection.Command.Parameters.Add("@Weight", SqlDbType.Int).Value = weight;
                dbConnection.Command.Parameters.Add("@MobileNumber", SqlDbType.VarChar).Value = mobileNumber;
                dbConnection.Command.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
                dbConnection.Connection.Open();
                dbConnection.Command.ExecuteNonQuery();
                dbConnection.Connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
                return false;
            }
            return true;
        }
    }
}
