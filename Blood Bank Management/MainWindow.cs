using System;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Today.ToString("D");
        }

        private void DonorRegisterButton_Click(object sender, EventArgs e)
        {
            var userRegistrationForm = new UserRegistration();
            userRegistrationForm.ShowDialog();
        }

        private void ShowAllDonorButton_Click(object sender, EventArgs e)
        {
            var allUserList = new AllUserList();
            allUserList.ShowDialog();
        }

        private void DonationButton_Click(object sender, EventArgs e)
        {
            var donationForm = new DonationForm();
            donationForm.ShowDialog();
        }

        private void RecipientButton_Click(object sender, EventArgs e)
        {
            var recipientForm = new RecipientForm();
            recipientForm.ShowDialog();
        }
    }
}
