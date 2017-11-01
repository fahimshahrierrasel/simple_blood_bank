using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class RecipientForm : Form
    {
        private UserController userController;
        private RecipitionController recipitionController;
        private BankController bankController;
        List<String> bloodGroups;
        public RecipientForm()
        {
            InitializeComponent();
            userController = new UserController();
            recipitionController = new RecipitionController();
            bankController = new BankController();
            bloodGroups = bankController.GetBloodGroups();
        }

        private void Recipient_Load(object sender, EventArgs e)
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
                BloodGroup.Text = bloodGroups[(int)userCells[3].Value];
                DateLabel.Text = DateTime.Now.ToString("D");

                ShowDonationForm(true);
                ShowSearchBoxAndDataGrid(false);
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

        private void RecipientCancelButton_Click(object sender, EventArgs e)
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

        private void RecipientSubmitButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(IdLabel.Text);
            int totalPack = (int)PacksNumericBox.Value;
            var currentDate = DateTime.Now;
            int bloodGroupId = bloodGroups.IndexOf(BloodGroup.Text);

            if (bankController.CanReciptBlood(totalPack, bloodGroupId))
            {
                if (recipitionController.InsertRecipitionToDb(userId, totalPack, currentDate))
                {
                    if (userController.UpdateLastDonationDate(userId, currentDate))
                    {
                        MessageBox.Show("Done");
                    }
                    else
                    {
                        MessageBox.Show("Something wrong to update");
                    }
                }
                else
                {
                    MessageBox.Show("Recipiention is not possible");
                }
            }
            else
            {
                MessageBox.Show("Not enough stroage avilable!!");
            }
        }
    }
}
