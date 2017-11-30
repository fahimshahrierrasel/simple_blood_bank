using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Blood_Bank_Management
{
    public class UserController
    {
        private readonly DbConnection _dbConnection;

        public UserController()
        {
            _dbConnection = new DbConnection();
        }

        // Insert Donor info to database
        public bool InsertDonorToDb(string userName, DateTime dob, int bloodGroup, int weight, string mobileNumber, string address)
        {
            try
            {
                _dbConnection.Command.CommandText =
                    "Insert into Donor (name, dob, bloodGroup, weight, mobileNo, address) Values(@UserName, @Dob, @BloodGroup, @Weight, @MobileNumber, @Address)";
                _dbConnection.Command.Parameters.Add("@Username", SqlDbType.VarChar).Value = userName;
                _dbConnection.Command.Parameters.Add("@Dob", SqlDbType.Date).Value = dob.Date;
                _dbConnection.Command.Parameters.Add("@BloodGroup", SqlDbType.Int).Value = bloodGroup;
                _dbConnection.Command.Parameters.Add("@Weight", SqlDbType.Int).Value = weight;
                _dbConnection.Command.Parameters.Add("@MobileNumber", SqlDbType.VarChar).Value = mobileNumber;
                _dbConnection.Command.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
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

        public DataTable GetAllUser()
        {
            DataTable userDataTable = null;
            try
            {
                _dbConnection.Command.CommandText = "Select * From Donor";
                _dbConnection.Connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(_dbConnection.Command);
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
                _dbConnection.Connection.Close();
            }
            return userDataTable;
        }

        public bool UpdateLastDonationDate(int donorId, DateTime currentDate)
        {
            // UPDATE CustTest SET CustID = @p1 , CustName = @p2 WHERE ( CustID = @p3 AND CustName = @p4 )
            try
            {
                _dbConnection.Command.CommandText =
                    "UPDATE Donor SET lastDonationDate = @CurrDate WHERE DonorId = @DID";
                _dbConnection.Command.Parameters.Add("@CurrDate", SqlDbType.Date).Value = currentDate.Date;
                _dbConnection.Command.Parameters.Add("@DID", SqlDbType.Int).Value = donorId;
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

        public bool UpdateLastRecipientDate(int donorId, DateTime currentDate)
        {
            // UPDATE CustTest SET CustID = @p1 , CustName = @p2 WHERE ( CustID = @p3 AND CustName = @p4 )
            try
            {
                _dbConnection.Command.CommandText =
                    "UPDATE Donor SET lastrecipientDate = @CurrDate WHERE DonorId = @DID";
                _dbConnection.Command.Parameters.Add("@CurrDate", SqlDbType.Date).Value = currentDate.Date;
                _dbConnection.Command.Parameters.Add("@DID", SqlDbType.Int).Value = donorId;
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

        private bool HasEnoughWeight(int weight)
        {
            return weight >= 50;
        }

        private bool IsMobileNumber(string mobileNumber)
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
            validate = HasEnoughWeight(weight);
            
            // Checking if mobile number is valid. like mobile number is all numeric
            validate = IsMobileNumber(mobileNumber);
            
            // Checking if user adress is empty
            validate = address.Length > 0;

            validate = HasEnoughAgeToDonate(dob);
            
            return validate;
        }
    }
}
