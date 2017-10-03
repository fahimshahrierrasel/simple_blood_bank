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
            this.donotRegisterButton = new System.Windows.Forms.Button();
            this.showAllDonorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // donotRegisterButton
            // 
            this.donotRegisterButton.AutoSize = true;
            this.donotRegisterButton.Location = new System.Drawing.Point(51, 57);
            this.donotRegisterButton.Name = "donotRegisterButton";
            this.donotRegisterButton.Size = new System.Drawing.Size(88, 23);
            this.donotRegisterButton.TabIndex = 0;
            this.donotRegisterButton.Text = "Register Donor";
            this.donotRegisterButton.UseVisualStyleBackColor = true;
            // 
            // showAllDonorButton
            // 
            this.showAllDonorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showAllDonorButton.AutoSize = true;
            this.showAllDonorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showAllDonorButton.Location = new System.Drawing.Point(288, 56);
            this.showAllDonorButton.Name = "showAllDonorButton";
            this.showAllDonorButton.Size = new System.Drawing.Size(91, 25);
            this.showAllDonorButton.TabIndex = 1;
            this.showAllDonorButton.Text = "Show All Dono";
            this.showAllDonorButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.showAllDonorButton);
            this.Controls.Add(this.donotRegisterButton);
            this.Name = "MainWindow";
            this.Text = "Blood Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button donotRegisterButton;
        private System.Windows.Forms.Button showAllDonorButton;
    }
}

