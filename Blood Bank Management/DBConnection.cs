using System.Configuration;
using System.Data.SqlClient;

namespace Blood_Bank_Management
{
    class DbConnection
    {
        private SqlConnection connection;
        private SqlCommand command;

        public SqlConnection Connection
        {
            get { return connection; }
        }

        public SqlCommand Command
        {
            get { return command; }
        }

        public DbConnection()
        {
            connection = new SqlConnection();
            command = new SqlCommand();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["BBConnectionString"].ConnectionString;
            command.Connection = connection;
        }

        public void ClearCommandText()
        {
            command.Parameters.Clear();
        }
    }
}
