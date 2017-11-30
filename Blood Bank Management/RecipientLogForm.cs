using System;
using System.Data;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class RecipientLogForm : Form
    {
        private readonly RecipitionController _recipitionController;
        public RecipientLogForm()
        {
            InitializeComponent();
            _recipitionController = new RecipitionController();
        }

        private void RecipientLogForm_Load(object sender, EventArgs e)
        {
            RecipientDataGridView.DataSource = _recipitionController.GetRecipientInformation();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)RecipientDataGridView.DataSource).DefaultView.RowFilter = $"name LIKE '{SearchTextBox.Text}%'";
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.Show("Search Donor by their name", SearchTextBox, 0, SearchTextBox.Height, 2000);
        }
    }
}
