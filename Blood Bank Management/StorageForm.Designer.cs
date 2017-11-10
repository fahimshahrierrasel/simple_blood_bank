namespace Blood_Bank_Management
{
    partial class StorageForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StorageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StorageChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageChart
            // 
            this.StorageChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.StorageChart.ChartAreas.Add(chartArea1);
            this.StorageChart.Location = new System.Drawing.Point(12, 71);
            this.StorageChart.Name = "StorageChart";
            this.StorageChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.StorageChart.Series.Add(series1);
            this.StorageChart.Size = new System.Drawing.Size(489, 300);
            this.StorageChart.TabIndex = 0;
            this.StorageChart.Text = "Storage";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Avilable Blood Packs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StorageChart);
            this.Name = "StorageForm";
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StorageChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StorageChart;
        private System.Windows.Forms.Label label1;
    }
}