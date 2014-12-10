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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chart_Ausgabe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDownChart = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_ymax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ymin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Ausgabe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymin)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(110, 414);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(454, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // chart_Ausgabe
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart_Ausgabe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Ausgabe.Legends.Add(legend1);
            this.chart_Ausgabe.Location = new System.Drawing.Point(110, 26);
            this.chart_Ausgabe.Name = "chart_Ausgabe";
            this.chart_Ausgabe.Size = new System.Drawing.Size(634, 350);
            this.chart_Ausgabe.TabIndex = 1;
            this.chart_Ausgabe.Text = "chart1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            title1.Name = "Title1";
            this.chart_Ausgabe.Titles.Add(title1);
            // 
            // numericUpDownChart
            // 
            this.numericUpDownChart.Location = new System.Drawing.Point(598, 414);
            this.numericUpDownChart.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownChart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anzahl der Messungen";
            // 
            // numericUpDown_ymax
            // 
            this.numericUpDown_ymax.Location = new System.Drawing.Point(12, 49);
            this.numericUpDown_ymax.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown_ymax.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            -2147483648});
            this.numericUpDown_ymax.Name = "numericUpDown_ymax";
            this.numericUpDown_ymax.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_ymax.TabIndex = 4;
            this.numericUpDown_ymax.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_ymax.ValueChanged += new System.EventHandler(this.numericUpDown_ymax_ValueChanged);
            // 
            // numericUpDown_ymin
            // 
            this.numericUpDown_ymin.Location = new System.Drawing.Point(12, 244);
            this.numericUpDown_ymin.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown_ymin.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            -2147483648});
            this.numericUpDown_ymin.Name = "numericUpDown_ymin";
            this.numericUpDown_ymin.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_ymin.TabIndex = 5;
            this.numericUpDown_ymin.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y-Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y-Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Timeline";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 486);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_ymin);
            this.Controls.Add(this.numericUpDown_ymax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownChart);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart_Ausgabe);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Ausgabe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_Ausgabe;
        private System.Windows.Forms.NumericUpDown numericUpDownChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_ymax;
        private System.Windows.Forms.NumericUpDown numericUpDown_ymin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}