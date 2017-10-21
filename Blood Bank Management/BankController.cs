using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management
{
    class BankController
    {
        private DbConnection dbConnection;

        public BankController()
        {
            this.dbConnection = new DbConnection();
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
    }
}
