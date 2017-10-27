using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class Donation : Form
    {
        private UserController userController;
        private DonationController donationController;
        private BankController bankController;
        List<String> bloodGroups;
        public Donation()
        {
            InitializeComponent();
            userController = new UserController();
            donationController = new DonationController();
            bankController = new BankController();
            bloodGroups = bankController.GetBloodGroups();
        }

        private void Donation_Load(object sender, EventArgs e)
        {
            AllUserDataGridView.DataSource = userController.GetAllUser();

            try
            {
                AllUserDataGridView.Columns["Donorid"].HeaderText = @"User ID";
                AllUserDataGridView.Columns["name"].HeaderText = @"Name";
                AllUserDataGridView.Columns["dob"].HeaderText = @"Date of Birth";
                AllUserDataGridView.Columns["bloodGroup"].HeaderText = @"Blood Group";
                AllUserDataGridView.Columns["weight"].HeaderText = @"Weight";
                AllUserDataGridView.Columns["mobileNo"].HeaderText = @"Mobile Number";
                AllUserDataGridView.Columns["address"].HeaderText = @"Address";
                AllUserDataGridView.Columns["lastDonationDate"].HeaderText = @"Last Donation Date";
                AllUserDataGridView.Columns["lastrecipientDate"].HeaderText = @"Last Recipient Date";
            }
            catch (NullReferenceException nullReferenceException)
            {
                Console.WriteLine(nullReferenceException.StackTrace);
            }
        }

        private void AllUserDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                DataGridViewCellCollection userCells = AllUserDataGridView.Rows[e.RowIndex].Cells;

                IdLabel.Text = userCells[0].Value.ToString();
                NameLabel.Text = userCells[1].Value.ToString();
                MobileNumberLabel.Text = userCells[5].Value.ToString();
                PacksNumericBox.Value = 1;
                DateLabel.Text = DateTime.Now.ToString("D");
                BloodGroup.Text = bloodGroups[(int) userCells[3].Value];

                DateTime lastDonationDate = (DateTime) userCells[7].Value;
                
                if ((DateTime.Now.Date - lastDonationDate.Date).TotalDays >= 90)
                {
                    ShowDonationForm(true);
                    ShowSearchBoxAndDataGrid(false);
                }
                else
                {
                    MessageBox.Show(String.Format("User Last Donation Date is {0}. Which is less then 90 days from Today", lastDonationDate.ToShortDateString()), "Warning!!");
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)AllUserDataGridView.DataSource).DefaultView.RowFilter = $"MobileNo LIKE '{SearchTextBox.Text}%'";
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.Show("Search User by Mobile Number", SearchTextBox, 0, SearchTextBox.Height, 2000);
        }

        private void ShowSearchBoxAndDataGrid(bool show)
        {
            SearchTextBox.Visible = show;
            AllUserDataGridView.Visible = show;
        }

        private void ShowDonationForm(bool show)
        {
            IdLabelTitle.Visible = show;
            IdLabel.Visible = show;
            NameLabelTitle.Visible = show;
            NameLabel.Visible = show;
            MobileNumberLabelTitle.Visible = show;
            MobileNumberLabel.Visible = show;
            PacksLabelTitle.Visible = show;
            PacksNumericBox.Visible = show;
            DateLabelTitle.Visible = show;
            DateLabel.Visible = show;
            BloodGroupLabel.Visible = show;
            BloodGroup.Visible = show;
            DonationSubmitButton.Visible = show;
        }

        private bool IsFormVisible()
        {
            return NameLabel.Visible;
        }

        private void DonationCancelButton_Click(object sender, EventArgs e)
        {
            if (IsFormVisible())
            {
                ShowDonationForm(false);
                ShowSearchBoxAndDataGrid(true);
            }
            else
            {
                Close();
            }
        }

        private void DonationSubmitButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(IdLabel.Text);
            int totalPack = (int) PacksNumericBox.Value;
            var currentDate = DateTime.Now;

            if (donationController.InsertDonationToDb(userId, totalPack, currentDate))
            {
                if (bankController.UpdateStorageForBloodGroup(totalPack, bloodGroups.IndexOf(BloodGroup.Text)))
                {
                    if (userController.UpdateLastDonationDate(userId, currentDate))
                    {
                        MessageBox.Show("Done");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong to update");
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong to update");
                }

            }
            else
            {
                MessageBox.Show("Donation is not possible");
            }
        }
    }
}
