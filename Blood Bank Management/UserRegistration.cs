using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class UserRegistration : Form
    {
        private readonly UserController _userController;
        private readonly BankController _bankController;
        public UserRegistration()
        {
            InitializeComponent();
            _userController = new UserController();
            _bankController = new BankController();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            PopulateBloodGroup();
        }

        private void PopulateBloodGroup()
        {
            List<String> bloodGroups = _bankController.GetBloodGroups();
            
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

            if (_userController.ValidateRegistrationData(userName, dob, weight, mobileNumber, address))
            {
                if (_userController.InsertDonorToDb(userName, dob, bloodGroup, weight, mobileNumber, address))
                {
                    CleanTextFields();
                    MessageBox.Show(@"Name should not be empty
Weight should be >= 40
Mobile Number should be all numeric
Address should not empty!", @"Success");
                }
                else
                {
                    MessageBox.Show(@"Name should not be empty
Weight should be >= 40
Mobile Number should be all numeric
Address should not empty!", @"Failed");
                }
            }
            else
            {
                MessageBox.Show(@"Name should not be empty
Weight should be >= 40
Mobile Number should be all numeric
Address should not empty!", @"Error");
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
            Close();
        }
    }
}
