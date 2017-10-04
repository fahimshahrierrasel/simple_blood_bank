using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class UserRegistration : Form
    {
        private DbConnection dbConnection;
        public UserRegistration()
        {
            InitializeComponent();
            dbConnection = new DbConnection();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            PopulateBloodGroup();
        }

        private void PopulateBloodGroup()
        {
            dbConnection.Command.CommandText = "Select * From BloodGroup";
            dbConnection.Connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(dbConnection.Command);
            dbConnection.Connection.Close();
            
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "BloodGroup");
            DataTable productTable = dataSet.Tables["BloodGroup"];
            
            foreach (DataRow dr in productTable.Rows)
            {
                userBloodGroup.Items.Add(dr["bgName"].ToString());
            }

            userBloodGroup.SelectedIndex = 0;
        }
        
        private void RegisterButtonClickListener(object sender, EventArgs e)
        {
            bool validate = true;
            
            string userName = userFullName.Text;
            string dob = userDateOfBirth.Value.ToString("dd/MM/yyyy");
            string bloodGroup = Convert.ToString(userBloodGroup.SelectedIndex);
            int weight = Convert.ToInt32(userWeight.Text);
            string mobileNumber = userMobileNumber.Text;
            string address = userAddress.Text;

            
            // Checking if User Name is empty
            if (userName.Length <= 0)
                validate = false;
            // Checking if User is under weight
            if (weight <= 40)
                validate = false;
            // Checking if mobile number is valid. like mobile number is all numeric
            if (!Regex.IsMatch(mobileNumber, @"^\d+$"))
                validate = false;
            // Checking if user adress is empty
            if (address.Length <= 0)
                validate = false;

            if (validate) {

                dbConnection.Command.CommandText = "";

                dbConnection.Connection.Open();
                dbConnection.Command.ExecuteNonQuery();
                dbConnection.Connection.Close();
            } else
            {
                MessageBox.Show(String.Format("Name should not be empty\nWeight should be >= 40\nMobile Number should be all numeric\nAddress should not empty!"), "Error");
            }
        }
    }
}
