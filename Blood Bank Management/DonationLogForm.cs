using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class DonationLogForm : Form
    {
        private DonationController donationController;
        public DonationLogForm()
        {
            InitializeComponent();
            donationController = new DonationController();
        }

        private void DonationLogForm_Load(object sender, EventArgs e)
        {
            DonationDataGridView.DataSource = donationController.GetDonationInformation();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)DonationDataGridView.DataSource).DefaultView.RowFilter = $"name LIKE '{SearchTextBox.Text}%'";
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.Show("Search Donor by their name", SearchTextBox, 0, SearchTextBox.Height, 2000);
        }
    }
}
