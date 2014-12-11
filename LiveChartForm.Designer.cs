namespace PharMS_Steuerung
{
    partial class LiveChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LiveChart_Ausgabe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown_ymax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ymin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Botton = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelright = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Max = new System.Windows.Forms.Label();
            this.lb_Min = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LiveChart_Ausgabe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymin)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelright.SuspendLayout();
            this.SuspendLayout();
            // 
            // LiveChart_Ausgabe
            // 
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.LiveChart_Ausgabe.ChartAreas.Add(chartArea2);
            this.LiveChart_Ausgabe.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.LiveChart_Ausgabe.Legends.Add(legend2);
            this.LiveChart_Ausgabe.Location = new System.Drawing.Point(116, 0);
            this.LiveChart_Ausgabe.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.LiveChart_Ausgabe.Name = "LiveChart_Ausgabe";
            this.LiveChart_Ausgabe.Size = new System.Drawing.Size(661, 374);
            this.LiveChart_Ausgabe.TabIndex = 1;
            this.LiveChart_Ausgabe.Text = "chart1";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            title2.Name = "Title1";
            this.LiveChart_Ausgabe.Titles.Add(title2);
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
            // Botton
            // 
            this.Botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Botton.Location = new System.Drawing.Point(0, 374);
            this.Botton.Name = "Botton";
            this.Botton.Size = new System.Drawing.Size(896, 112);
            this.Botton.TabIndex = 9;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.numericUpDown_ymax);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.numericUpDown_ymin);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(116, 374);
            this.panelLeft.TabIndex = 10;
            // 
            // panelright
            // 
            this.panelright.Controls.Add(this.label6);
            this.panelright.Controls.Add(this.label5);
            this.panelright.Controls.Add(this.lb_Max);
            this.panelright.Controls.Add(this.lb_Min);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelright.Location = new System.Drawing.Point(777, 0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(119, 374);
            this.panelright.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Minimum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Maximum";
            // 
            // lb_Max
            // 
            this.lb_Max.AutoSize = true;
            this.lb_Max.Location = new System.Drawing.Point(60, 60);
            this.lb_Max.Name = "lb_Max";
            this.lb_Max.Size = new System.Drawing.Size(13, 13);
            this.lb_Max.TabIndex = 1;
            this.lb_Max.Text = "0";
            // 
            // lb_Min
            // 
            this.lb_Min.AutoSize = true;
            this.lb_Min.Location = new System.Drawing.Point(60, 83);
            this.lb_Min.Name = "lb_Min";
            this.lb_Min.Size = new System.Drawing.Size(13, 13);
            this.lb_Min.TabIndex = 0;
            this.lb_Min.Text = "0";
            // 
            // LiveChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 486);
            this.Controls.Add(this.LiveChart_Ausgabe);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.Botton);
            this.Name = "LiveChartForm";
            this.Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.LiveChart_Ausgabe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ymin)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart LiveChart_Ausgabe;
        private System.Windows.Forms.NumericUpDown numericUpDown_ymax;
        private System.Windows.Forms.NumericUpDown numericUpDown_ymin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Botton;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelright;
        public System.Windows.Forms.Label lb_Max;
        public System.Windows.Forms.Label lb_Min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}