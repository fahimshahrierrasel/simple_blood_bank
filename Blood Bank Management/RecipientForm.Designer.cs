namespace Blood_Bank_Management
{
    partial class RecipientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AllUserDataGridView = new System.Windows.Forms.DataGridView();
            this.DonationCancelButton = new System.Windows.Forms.Button();
            this.DonationSubmitButton = new System.Windows.Forms.Button();
            this.PacksNumericBox = new System.Windows.Forms.NumericUpDown();
            this.PacksLabelTitle = new System.Windows.Forms.Label();
            this.NameLabelTitle = new System.Windows.Forms.Label();
            this.IdLabelTitle = new System.Windows.Forms.Label();
            this.MobileNumberLabelTitle = new System.Windows.Forms.Label();
            this.DateLabelTitle = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MobileNumberLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.BloodGroup = new System.Windows.Forms.Label();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacksNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(131, 44);
            this.SearchTextBox.MaxLength = 15;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(265, 26);
            this.SearchTextBox.TabIndex = 11;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recipient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllUserDataGridView
            // 
            this.AllUserDataGridView.AllowUserToAddRows = false;
            this.AllUserDataGridView.AllowUserToDeleteRows = false;
            this.AllUserDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllUserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUserDataGridView.Location = new System.Drawing.Point(50, 80);
            this.AllUserDataGridView.Name = "AllUserDataGridView";
            this.AllUserDataGridView.ReadOnly = true;
            this.AllUserDataGridView.Size = new System.Drawing.Size(425, 175);
            this.AllUserDataGridView.TabIndex = 9;
            this.AllUserDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllUserDataGridView_CellDoubleClick);
            // 
            // DonationCancelButton
            // 
            this.DonationCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationCancelButton.Location = new System.Drawing.Point(12, 273);
            this.DonationCancelButton.Name = "DonationCancelButton";
            this.DonationCancelButton.Size = new System.Drawing.Size(75, 23);
            this.DonationCancelButton.TabIndex = 12;
            this.DonationCancelButton.Text = "Cancel";
            this.DonationCancelButton.UseVisualStyleBackColor = true;
            this.DonationCancelButton.Click += new System.EventHandler(this.RecipientCancelButton_Click);
            // 
            // DonationSubmitButton
            // 
            this.DonationSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationSubmitButton.Location = new System.Drawing.Point(434, 273);
            this.DonationSubmitButton.Name = "DonationSubmitButton";
            this.DonationSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.DonationSubmitButton.TabIndex = 13;
            this.DonationSubmitButton.Text = "Submit";
            this.DonationSubmitButton.UseVisualStyleBackColor = true;
            this.DonationSubmitButton.Visible = false;
            this.DonationSubmitButton.Click += new System.EventHandler(this.RecipientSubmitButton_Click);
            // 
            // PacksNumericBox
            // 
            this.PacksNumericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacksNumericBox.Location = new System.Drawing.Point(251, 166);
            this.PacksNumericBox.Name = "PacksNumericBox";
            this.PacksNumericBox.Size = new System.Drawing.Size(120, 22);
            this.PacksNumericBox.TabIndex = 14;
            this.PacksNumericBox.Visible = false;
            // 
            // PacksLabelTitle
            // 
            this.PacksLabelTitle.AutoSize = true;
            this.PacksLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacksLabelTitle.Location = new System.Drawing.Point(164, 168);
            this.PacksLabelTitle.Name = "PacksLabelTitle";
            this.PacksLabelTitle.Size = new System.Drawing.Size(81, 16);
            this.PacksLabelTitle.TabIndex = 15;
            this.PacksLabelTitle.Text = "No of Packs";
            this.PacksLabelTitle.Visible = false;
            // 
            // NameLabelTitle
            // 
            this.NameLabelTitle.AutoSize = true;
            this.NameLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabelTitle.Location = new System.Drawing.Point(200, 109);
            this.NameLabelTitle.Name = "NameLabelTitle";
            this.NameLabelTitle.Size = new System.Drawing.Size(45, 16);
            this.NameLabelTitle.TabIndex = 16;
            this.NameLabelTitle.Text = "Name";
            this.NameLabelTitle.Visible = false;
            // 
            // IdLabelTitle
            // 
            this.IdLabelTitle.AutoSize = true;
            this.IdLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabelTitle.Location = new System.Drawing.Point(224, 80);
            this.IdLabelTitle.Name = "IdLabelTitle";
            this.IdLabelTitle.Size = new System.Drawing.Size(21, 16);
            this.IdLabelTitle.TabIndex = 17;
            this.IdLabelTitle.Text = "ID";
            this.IdLabelTitle.Visible = false;
            // 
            // MobileNumberLabelTitle
            // 
            this.MobileNumberLabelTitle.AutoSize = true;
            this.MobileNumberLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumberLabelTitle.Location = new System.Drawing.Point(145, 137);
            this.MobileNumberLabelTitle.Name = "MobileNumberLabelTitle";
            this.MobileNumberLabelTitle.Size = new System.Drawing.Size(100, 16);
            this.MobileNumberLabelTitle.TabIndex = 18;
            this.MobileNumberLabelTitle.Text = "Mobile Number";
            this.MobileNumberLabelTitle.Visible = false;
            // 
            // DateLabelTitle
            // 
            this.DateLabelTitle.AutoSize = true;
            this.DateLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabelTitle.Location = new System.Drawing.Point(208, 220);
            this.DateLabelTitle.Name = "DateLabelTitle";
            this.DateLabelTitle.Size = new System.Drawing.Size(37, 16);
            this.DateLabelTitle.TabIndex = 19;
            this.DateLabelTitle.Text = "Date";
            this.DateLabelTitle.Visible = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(251, 80);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 16);
            this.IdLabel.TabIndex = 20;
            this.IdLabel.Text = "Id";
            this.IdLabel.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(251, 109);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 16);
            this.NameLabel.TabIndex = 21;
            this.NameLabel.Text = "Name";
            this.NameLabel.Visible = false;
            // 
            // MobileNumberLabel
            // 
            this.MobileNumberLabel.AutoSize = true;
            this.MobileNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumberLabel.Location = new System.Drawing.Point(251, 137);
            this.MobileNumberLabel.Name = "MobileNumberLabel";
            this.MobileNumberLabel.Size = new System.Drawing.Size(100, 16);
            this.MobileNumberLabel.TabIndex = 22;
            this.MobileNumberLabel.Text = "Mobile Number";
            this.MobileNumberLabel.Visible = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(251, 220);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(82, 16);
            this.DateLabel.TabIndex = 23;
            this.DateLabel.Text = "Current Date";
            this.DateLabel.Visible = false;
            // 
            // BloodGroup
            // 
            this.BloodGroup.AutoSize = true;
            this.BloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroup.Location = new System.Drawing.Point(251, 195);
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.Size = new System.Drawing.Size(84, 16);
            this.BloodGroup.TabIndex = 25;
            this.BloodGroup.Text = "Blood Group";
            this.BloodGroup.Visible = false;
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupLabel.Location = new System.Drawing.Point(161, 195);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(84, 16);
            this.BloodGroupLabel.TabIndex = 24;
            this.BloodGroupLabel.Text = "Blood Group";
            this.BloodGroupLabel.Visible = false;
            // 
            // Recipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 308);
            this.Controls.Add(this.BloodGroup);
            this.Controls.Add(this.BloodGroupLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.MobileNumberLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.DateLabelTitle);
            this.Controls.Add(this.MobileNumberLabelTitle);
            this.Controls.Add(this.IdLabelTitle);
            this.Controls.Add(this.NameLabelTitle);
            this.Controls.Add(this.PacksLabelTitle);
            this.Controls.Add(this.PacksNumericBox);
            this.Controls.Add(this.DonationSubmitButton);
            this.Controls.Add(this.DonationCancelButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllUserDataGridView);
            this.Name = "Recipient";
            this.Text = "Donation";
            this.Load += new System.EventHandler(this.Recipient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllUserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacksNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AllUserDataGridView;
        private System.Windows.Forms.Button DonationCancelButton;
        private System.Windows.Forms.Button DonationSubmitButton;
        private System.Windows.Forms.NumericUpDown PacksNumericBox;
        private System.Windows.Forms.Label PacksLabelTitle;
        private System.Windows.Forms.Label NameLabelTitle;
        private System.Windows.Forms.Label IdLabelTitle;
        private System.Windows.Forms.Label MobileNumberLabelTitle;
        private System.Windows.Forms.Label DateLabelTitle;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MobileNumberLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label BloodGroup;
        private System.Windows.Forms.Label BloodGroupLabel;
    }
}