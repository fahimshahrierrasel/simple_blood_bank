using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Blood_Bank_Management
{
    public class UserController
    {
        private DbConnection dbConnection;

        public UserController()
        {
            dbConnection = new DbConnection();
        }

        // Insert Donor info to database
        public bool InsertDonorToDb(string userName, DateTime dob, int bloodGroup, int weight, string mobileNumber, string address)
        {
            try
            {
                dbConnection.Command.CommandText =
                    "Insert into Donor (name, dob, bloodGroup, weight, mobileNo, address) Values(@UserName, @Dob, @BloodGroup, @Weight, @MobileNumber, @Address)";
                dbConnection.Command.Parameters.Add("@Username", SqlDbType.VarChar).Value = userName;
                dbConnection.Command.Parameters.Add("@Dob", SqlDbType.Date).Value = dob.Date;
                dbConnection.Command.Parameters.Add("@BloodGroup", SqlDbType.Int).Value = bloodGroup;
                dbConnection.Command.Parameters.Add("@Weight", SqlDbType.Int).Value = weight;
                dbConnection.Command.Parameters.Add("@MobileNumber", SqlDbType.VarChar).Value = mobileNumber;
                dbConnection.Command.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
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

        public DataTable GetAllUser()
        {
            DataTable userDataTable = null;
            try
            {
                dbConnection.Command.CommandText = "Select * From Donor";
                dbConnection.Connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(dbConnection.Command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Donor");
                userDataTable = dataSet.Tables["Donor"];
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
            finally
            {
                dbConnection.Connection.Close();
            }
            return userDataTable;
        }

        public bool UpdateLastDonationDate(int donorId, DateTime currentDate)
        {
            // UPDATE CustTest SET CustID = @p1 , CustName = @p2 WHERE ( CustID = @p3 AND CustName = @p4 )
            try
            {
                dbConnection.Command.CommandText =
                    "UPDATE Donor SET lastDonationDate = @CurrDate WHERE DonorId = @DID";
                dbConnection.Command.Parameters.Add("@CurrDate", SqlDbType.Date).Value = currentDate.Date;
                dbConnection.Command.Parameters.Add("@DID", SqlDbType.Int).Value = donorId;
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

        public bool UpdateLastRecipientDate(int donorId, DateTime currentDate)
        {
            // UPDATE CustTest SET CustID = @p1 , CustName = @p2 WHERE ( CustID = @p3 AND CustName = @p4 )
            try
            {
                dbConnection.Command.CommandText =
                    "UPDATE Donor SET lastrecipientDate = @CurrDate WHERE DonorId = @DID";
                dbConnection.Command.Parameters.Add("@CurrDate", SqlDbType.Date).Value = currentDate.Date;
                dbConnection.Command.Parameters.Add("@DID", SqlDbType.Int).Value = donorId;
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

        public bool HaveEnoughWeight(int weight)
        {
            return weight >= 50;
        }

        public bool IsMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, @"^\d+$");
        }

        public bool HasEnoughAgeToDonate(DateTime dob)
        {
            double totalDays = (DateTime.Now.Date - dob.Date).TotalDays;
            return ((totalDays / 365) >= 18.0);
        }

        public bool ValidateRegistrationData(string userName, DateTime dob, int weight, string mobileNumber, string address)
        {
            bool validate;
            
            // Checking if User Name is empty
            validate = userName.Length > 0;
            
            // Checking if User is under weight
            validate = HaveEnoughWeight(weight);
            
            // Checking if mobile number is valid. like mobile number is all numeric
            validate = IsMobileNumber(mobileNumber);
            
            // Checking if user adress is empty
            validate = address.Length > 0;

            validate = HasEnoughAgeToDonate(dob);
            
            return validate;
        }
    }
}
