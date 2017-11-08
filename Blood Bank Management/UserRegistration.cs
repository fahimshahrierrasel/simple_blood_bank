using System;
using System.Collections.Generic;
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
            string userName = userFullName.Text;
            DateTime dob = userDateOfBirth.Value;
            int bloodGroup = userBloodGroup.SelectedIndex;
            int weight = Convert.ToInt32(userWeight.Text);
            string mobileNumber = userMobileNumber.Text;
            string address = userAddress.Text;

            if (userController.ValidateRegistrationData(userName, dob, weight, mobileNumber, address))
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
