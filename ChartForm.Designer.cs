namespace PharMS_Steuerung
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chart_Ausgabe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDownChart = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Ausgabe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChart)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(110, 395);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(361, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // chart_Ausgabe
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_Ausgabe.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_Ausgabe.Legends.Add(legend3);
            this.chart_Ausgabe.Location = new System.Drawing.Point(110, 29);
            this.chart_Ausgabe.Name = "chart_Ausgabe";
            this.chart_Ausgabe.Size = new System.Drawing.Size(490, 300);
            this.chart_Ausgabe.TabIndex = 1;
            this.chart_Ausgabe.Text = "chart1";
            // 
            // numericUpDownChart
            // 
            this.numericUpDownChart.Location = new System.Drawing.Point(110, 477);
            this.numericUpDownChart.Name = "numericUpDownChart";
            this.numericUpDownChart.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownChart.TabIndex = 2;
            this.numericUpDownChart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChart.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.numericUpDownChart);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart_Ausgabe);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Ausgabe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_Ausgabe;
        private System.Windows.Forms.NumericUpDown numericUpDownChart;
    }
}