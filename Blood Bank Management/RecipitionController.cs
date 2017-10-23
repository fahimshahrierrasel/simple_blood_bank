﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management
{
    class RecipitionController
    {
        private DbConnection dbConnection;

        public RecipitionController()
        {
            dbConnection = new DbConnection();
        }

        // Insert Donor info to database
        public bool InsertRecipitionToDb(int donorId, int quantity, DateTime donationDate)
        {
            try
            {
                dbConnection.Command.CommandText =
                    "Insert into Reciption (DonorId, quantity, date) Values(@DID, @Quantity, @CurrentDate)";
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
