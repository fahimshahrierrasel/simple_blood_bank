using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class UserRegistration : Form
    {
        private UserController userController;
        private BankController bankController;
        public UserRegistration()
        {
            InitializeComponent();
            userController = new UserController();
            bankController = new BankController();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            PopulateBloodGroup();
        }

        private void PopulateBloodGroup()
        {
            List<String> bloodGroups = bankController.GetBloodGroups();
            
            foreach (String bloodGroup in bloodGroups)
            {
                userBloodGroup.Items.Add(bloodGroup);
            }

            userBloodGroup.SelectedIndex = 0;
        }
        
        private void RegisterButtonClickListener(object sender, EventArgs e)
        {
            bool validate = true;
            
            string userName = userFullName.Text;
            DateTime dob = userDateOfBirth.Value;
            int bloodGroup = userBloodGroup.SelectedIndex;
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

            if (validate)
            {
                if (userController.InsertDonorToDb(userName, dob, bloodGroup, weight, mobileNumber, address))
                {
                    CleanTextFields();
                    MessageBox.Show("Donor successfully add!", "Success");
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "Failed");
                }
            }
            else
            {
                MessageBox.Show("Name should not be empty\nWeight should be >= 40\nMobile Number should be all numeric\nAddress should not empty!", "Error");
            }
        }

        private void CleanTextFields()
        {
            userFullName.Text = "";
            userDateOfBirth.Value = DateTime.Today;
            userBloodGroup.SelectedIndex = 0;
            userWeight.Text = @"0";
            userMobileNumber.Text = "";
            userAddress.Text = "";
        }

        private void RegistrationCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
