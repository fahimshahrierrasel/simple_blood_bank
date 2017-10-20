﻿using System;
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
    }
}