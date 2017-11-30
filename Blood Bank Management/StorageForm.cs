using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Blood_Bank_Management
{
    public partial class StorageForm : Form
    {
        private readonly BankController _bankController;
        public StorageForm()
        {
            InitializeComponent();
            _bankController = new BankController();
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            StorageChart.DataSource = _bankController.GetStorageInformation();
            StorageChart.Series[0].XValueMember = "Blood Group";
            StorageChart.Series[0].YValueMembers = "Quantity";
            StorageChart.Series[0].ChartType = SeriesChartType.Column;
        }
    }
}
