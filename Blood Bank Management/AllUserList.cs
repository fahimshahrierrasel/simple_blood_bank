using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class AllUserList : Form
    {
        private UserController userController;
        private BankController bankController;
        private List<string> bloodGroups;
        
        public AllUserList()
        {
            InitializeComponent();
            userController = new UserController();
            bankController = new BankController();
            bloodGroups = bankController.GetBloodGroups();
        }

        private void AllUserList_Load(object sender, EventArgs e)
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
                var userInformation = new StringBuilder($"User ID: {userCells[0].Value}\n");
                userInformation.AppendLine($"Name: {userCells[1].Value}");
                userInformation.AppendLine($"Date of Birth: {userCells[2].Value}");
                userInformation.AppendLine($"Blood Broup: {bloodGroups[Convert.ToInt32(userCells[3].Value)]}");
                userInformation.AppendLine($"Weight: {userCells[4].Value} KG");
                userInformation.AppendLine($"Mobile No: {userCells[5].Value}");
                userInformation.AppendLine($"Address: {userCells[6].Value}");
                userInformation.AppendLine($"Last Donation Date: {userCells[7].Value}");
                userInformation.AppendLine($"Last Recipient Date: {userCells[8].Value}");
                MessageBox.Show(userInformation.ToString(), userCells[1].Value.ToString());
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
                ((DataTable) AllUserDataGridView.DataSource).DefaultView.RowFilter = $"MobileNo LIKE '{SearchTextBox.Text}%'";
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.Show("Search User by Mobile Number", SearchTextBox, 0, SearchTextBox.Height, 2000);
        }
    }
}
