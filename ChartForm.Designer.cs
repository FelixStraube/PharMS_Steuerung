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
            this.chart_Ausgabe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown_ymax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ymin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Max = new System.Windows.Forms.Label();
            this.lb_Min = new System.Windows.Forms.Label();
            this.panelright = new System.Windows.Forms.Panel();
            this.MesszyklusGridChart = new System.Windows.Forms.DataGridView();
            this.colVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnUndoZoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Ausgabe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymin)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesszyklusGridChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Ausgabe
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart_Ausgabe.ChartAreas.Add(chartArea1);
            this.chart_Ausgabe.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Ausgabe.Legends.Add(legend1);
            this.chart_Ausgabe.Location = new System.Drawing.Point(116, 0);
            this.chart_Ausgabe.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.chart_Ausgabe.Name = "chart_Ausgabe";
            this.chart_Ausgabe.Size = new System.Drawing.Size(570, 486);
            this.chart_Ausgabe.TabIndex = 1;
            this.chart_Ausgabe.Text = "chart1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            title1.Name = "Title1";
            this.chart_Ausgabe.Titles.Add(title1);
            // 
            // numericUpDown_ymax
            // 
            this.numericUpDown_ymax.Location = new System.Drawing.Point(27, 40);
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
            // 
            // numericUpDown_ymin
            // 
            this.numericUpDown_ymin.Location = new System.Drawing.Point(27, 99);
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
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y-Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y-Min";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnUndoZoom);
            this.panelLeft.Controls.Add(this.label6);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Controls.Add(this.lb_Max);
            this.panelLeft.Controls.Add(this.lb_Min);
            this.panelLeft.Controls.Add(this.numericUpDown_ymax);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.numericUpDown_ymin);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(116, 486);
            this.panelLeft.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Minimum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maximum";
            // 
            // lb_Max
            // 
            this.lb_Max.AutoSize = true;
            this.lb_Max.Location = new System.Drawing.Point(81, 155);
            this.lb_Max.Name = "lb_Max";
            this.lb_Max.Size = new System.Drawing.Size(13, 13);
            this.lb_Max.TabIndex = 9;
            this.lb_Max.Text = "0";
            // 
            // lb_Min
            // 
            this.lb_Min.AutoSize = true;
            this.lb_Min.Location = new System.Drawing.Point(81, 178);
            this.lb_Min.Name = "lb_Min";
            this.lb_Min.Size = new System.Drawing.Size(13, 13);
            this.lb_Min.TabIndex = 8;
            this.lb_Min.Text = "0";
            // 
            // panelright
            // 
            this.panelright.Controls.Add(this.MesszyklusGridChart);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelright.Location = new System.Drawing.Point(686, 0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(210, 486);
            this.panelright.TabIndex = 11;
            // 
            // MesszyklusGridChart
            // 
            this.MesszyklusGridChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MesszyklusGridChart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVisible});
            this.MesszyklusGridChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MesszyklusGridChart.Location = new System.Drawing.Point(0, 0);
            this.MesszyklusGridChart.Name = "MesszyklusGridChart";
            this.MesszyklusGridChart.Size = new System.Drawing.Size(210, 486);
            this.MesszyklusGridChart.TabIndex = 0;
            this.MesszyklusGridChart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MesszyklusGridChart_CellValueChanged);
            // 
            // colVisible
            // 
            this.colVisible.FillWeight = 60F;
            this.colVisible.HeaderText = "Anzeigen";
            this.colVisible.Name = "colVisible";
            this.colVisible.Width = 60;
            // 
            // btnUndoZoom
            // 
            this.btnUndoZoom.Location = new System.Drawing.Point(27, 222);
            this.btnUndoZoom.Name = "btnUndoZoom";
            this.btnUndoZoom.Size = new System.Drawing.Size(75, 23);
            this.btnUndoZoom.TabIndex = 12;
            this.btnUndoZoom.Text = "undo zoom";
            this.btnUndoZoom.UseVisualStyleBackColor = true;
            this.btnUndoZoom.Click += new System.EventHandler(this.btnUndoZoom_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 486);
            this.Controls.Add(this.chart_Ausgabe);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.panelLeft);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Ausgabe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymin)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelright.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MesszyklusGridChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart_Ausgabe;
        private System.Windows.Forms.NumericUpDown numericUpDown_ymax;
        private System.Windows.Forms.NumericUpDown numericUpDown_ymin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.DataGridView MesszyklusGridChart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lb_Max;
        public System.Windows.Forms.Label lb_Min;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colVisible;
        private System.Windows.Forms.Button btnUndoZoom;
    }
}