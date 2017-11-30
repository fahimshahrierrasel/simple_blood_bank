using System.Data.SqlClient;

namespace Blood_Bank_Management
{
    class DbConnection
    {
        private const string ConnString = @"Server=WINDOWSPROGRAMM\SQLEXPRESS; Database=BloodBank; Trusted_Connection=True;";
        private readonly SqlConnection connection;
        private readonly SqlCommand command;

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
            connection = new SqlConnection(ConnString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        public void ClearCommandText()
        {
            command.Parameters.Clear();
        }
    }
}
