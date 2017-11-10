namespace Blood_Bank_Management
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.DonorRegisterButton = new System.Windows.Forms.Button();
            this.ShowAllDonorButton = new System.Windows.Forms.Button();
            this.DonationButton = new System.Windows.Forms.Button();
            this.RecipientButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.StorageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DonorRegisterButton
            // 
            this.DonorRegisterButton.AutoSize = true;
            this.DonorRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorRegisterButton.Location = new System.Drawing.Point(40, 82);
            this.DonorRegisterButton.Name = "DonorRegisterButton";
            this.DonorRegisterButton.Size = new System.Drawing.Size(125, 35);
            this.DonorRegisterButton.TabIndex = 0;
            this.DonorRegisterButton.Text = "Register Donor";
            this.DonorRegisterButton.UseVisualStyleBackColor = true;
            this.DonorRegisterButton.Click += new System.EventHandler(this.DonorRegisterButton_Click);
            // 
            // ShowAllDonorButton
            // 
            this.ShowAllDonorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllDonorButton.AutoSize = true;
            this.ShowAllDonorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllDonorButton.Location = new System.Drawing.Point(419, 82);
            this.ShowAllDonorButton.Name = "ShowAllDonorButton";
            this.ShowAllDonorButton.Size = new System.Drawing.Size(125, 35);
            this.ShowAllDonorButton.TabIndex = 1;
            this.ShowAllDonorButton.Text = "Show All User";
            this.ShowAllDonorButton.UseVisualStyleBackColor = true;
            this.ShowAllDonorButton.Click += new System.EventHandler(this.ShowAllDonorButton_Click);
            // 
            // DonationButton
            // 
            this.DonationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationButton.Location = new System.Drawing.Point(40, 159);
            this.DonationButton.Name = "DonationButton";
            this.DonationButton.Size = new System.Drawing.Size(125, 35);
            this.DonationButton.TabIndex = 2;
            this.DonationButton.Text = "Donation";
            this.DonationButton.UseVisualStyleBackColor = true;
            this.DonationButton.Click += new System.EventHandler(this.DonationButton_Click);
            // 
            // RecipientButton
            // 
            this.RecipientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecipientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipientButton.Location = new System.Drawing.Point(419, 160);
            this.RecipientButton.Name = "RecipientButton";
            this.RecipientButton.Size = new System.Drawing.Size(125, 35);
            this.RecipientButton.TabIndex = 3;
            this.RecipientButton.Text = "Recipient";
            this.RecipientButton.UseVisualStyleBackColor = true;
            this.RecipientButton.Click += new System.EventHandler(this.RecipientButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(40, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Donation Log";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(419, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Recipient Log";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Simple Blood Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(0, 30);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(584, 25);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Current Date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(2, 18);
            this.linkLabel1.Location = new System.Drawing.Point(461, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "© Simple Blood Bank";
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // StorageButton
            // 
            this.StorageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StorageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageButton.Location = new System.Drawing.Point(40, 313);
            this.StorageButton.Name = "StorageButton";
            this.StorageButton.Size = new System.Drawing.Size(125, 35);
            this.StorageButton.TabIndex = 9;
            this.StorageButton.Text = "Storage";
            this.StorageButton.UseVisualStyleBackColor = true;
            this.StorageButton.Click += new System.EventHandler(this.StorageButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Blood_Bank_Management.Properties.Resources.blood_donation;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.StorageButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RecipientButton);
            this.Controls.Add(this.DonationButton);
            this.Controls.Add(this.ShowAllDonorButton);
            this.Controls.Add(this.DonorRegisterButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindow";
            this.Text = "Simple Blood Bank";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DonorRegisterButton;
        private System.Windows.Forms.Button ShowAllDonorButton;
        private System.Windows.Forms.Button DonationButton;
        private System.Windows.Forms.Button RecipientButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button StorageButton;
    }
}

