namespace Blood_Bank_Management
{
    partial class RecipientLogForm
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.RecipientDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RecipientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(102, 17);
            this.SearchTextBox.MaxLength = 15;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(265, 26);
            this.SearchTextBox.TabIndex = 14;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            // 
            // RecipientDataGridView
            // 
            this.RecipientDataGridView.AllowUserToAddRows = false;
            this.RecipientDataGridView.AllowUserToDeleteRows = false;
            this.RecipientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipientDataGridView.Location = new System.Drawing.Point(12, 60);
            this.RecipientDataGridView.Name = "RecipientDataGridView";
            this.RecipientDataGridView.ReadOnly = true;
            this.RecipientDataGridView.Size = new System.Drawing.Size(434, 217);
            this.RecipientDataGridView.TabIndex = 13;
            // 
            // RecipientLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 294);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.RecipientDataGridView);
            this.Name = "RecipientLogForm";
            this.Text = "Recipient Log";
            this.Load += new System.EventHandler(this.RecipientLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecipientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView RecipientDataGridView;
    }
}