namespace Blood_Bank_Management
{
    partial class DonationLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DonationDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DonationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DonationDataGridView
            // 
            this.DonationDataGridView.AllowUserToAddRows = false;
            this.DonationDataGridView.AllowUserToDeleteRows = false;
            this.DonationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonationDataGridView.Location = new System.Drawing.Point(12, 65);
            this.DonationDataGridView.Name = "DonationDataGridView";
            this.DonationDataGridView.ReadOnly = true;
            this.DonationDataGridView.Size = new System.Drawing.Size(434, 217);
            this.DonationDataGridView.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(102, 22);
            this.SearchTextBox.MaxLength = 15;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(265, 26);
            this.SearchTextBox.TabIndex = 12;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            // 
            // DonationLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 294);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DonationDataGridView);
            this.Name = "DonationLogForm";
            this.Text = "Donation Log";
            this.Load += new System.EventHandler(this.DonationLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DonationDataGridView;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}