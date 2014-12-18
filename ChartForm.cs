using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PharMS_Steuerung
{
    public partial class ChartForm : Form
    {

        public DataSet TEMP;
        public Form1 _Form1;
        public ChartForm(Form1 MainForm)
        {
            InitializeComponent();
            _Form1 = MainForm;

            int RowCount = MainForm.DBMain.dsPharms.Tables["Messwerte"].Rows.Count;
            int colMZ_ID = MainForm.DBMain.dsPharms.Tables["Messwerte"].Columns["MZ_ID"].Ordinal;
            string MZID = MainForm.DBMain.dsPharms.Tables["Messwerte"].Rows[RowCount - 1].ItemArray[colMZ_ID].ToString();//letzte zeile
            int[] MZ_ID = MainForm.DBMain.GetAllZyklusID().ToArray();

            DataView dvMesswerte = new DataView(MainForm.DBMain.dsPharms.Tables["Messwerte"]);

            Random rnd = new Random();

            foreach (int i in MZ_ID)
            {
                dvMesswerte.RowFilter = "MZ_ID = " + i + " AND MW1 <> -9999.9 AND MW2 <> -9999.9";
                dvMesswerte.Sort = "Datum";


                Series serie1 = new Series();

                serie1.Enabled = false;
                serie1.Points.DataBindY(dvMesswerte, "MW1");
                serie1.Name = "Sensor1 Zyklus: " + i.ToString();
                serie1.Color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                serie1.BorderColor = Color.FromArgb(164, 164, 164);
                serie1.ChartType = SeriesChartType.FastLine;
                serie1.BorderDashStyle = ChartDashStyle.Solid;
                serie1.BorderWidth = 2;
                serie1.ShadowColor = Color.FromArgb(128, 128, 128);
                serie1.ShadowOffset = 1;
                serie1.IsValueShownAsLabel = true;
                serie1.Font = new Font("Tahoma", 8.0f);
                serie1.BackSecondaryColor = Color.FromArgb(0, 102, 153);
                serie1.LabelForeColor = Color.FromArgb(100, 100, 100);
                chart_Ausgabe.Series.Add(serie1);

                Series serie2 = new Series();
                serie2.Enabled = false;
                serie2.Points.DataBindY(dvMesswerte, "MW2");
                serie2.Name = "Sensor2 Zyklus: " + i.ToString();
                serie2.Color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                serie2.BorderColor = Color.FromArgb(164, 164, 164);
                serie2.ChartType = SeriesChartType.FastLine;
                serie2.BorderDashStyle = ChartDashStyle.Solid;
                serie2.BorderWidth = 2;
                serie2.ShadowColor = Color.FromArgb(128, 128, 128);
                serie2.ShadowOffset = 1;
                serie2.IsValueShownAsLabel = true;
                serie2.Font = new Font("Tahoma", 8.0f);
                serie2.BackSecondaryColor = Color.FromArgb(0, 102, 153);
                serie2.LabelForeColor = Color.FromArgb(100, 100, 100);
                chart_Ausgabe.Series.Add(serie2);
                dvMesswerte.RowFilter = "MZ_ID = " + MZID + " AND MW1 <> -9999.9 AND MW2 <> -9999.9";

            }

            // chart_Ausgabe.DataSource = dvMesswerte;



            //  databind...        

            ChartArea ca = chart_Ausgabe.ChartAreas["ChartArea1"];
            ca.AxisX.Title = "[Anzahl Messwerte]";
            ca.AxisY.Title = "[nA]";

            ca.CursorX.IsUserEnabled = true;
            ca.CursorX.IsUserSelectionEnabled = true;
            ca.CursorY.IsUserEnabled = true;
            ca.CursorY.IsUserSelectionEnabled = true;

            ca.AxisX.ScaleView.Zoomable = true;
            ca.AxisY.ScaleView.Zoomable = true;

            chart_Ausgabe.DataBind();
            FillGrid();
            MesszyklusGridChart.AllowUserToAddRows = false;
        }

        private void FillGrid()
        {
            DataView dvMesszyklus = new DataView(_Form1.DBMain.dsPharms.Tables["Messzyklus"]);
            MesszyklusGridChart.DataSource = dvMesszyklus;
            dvMesszyklus.Sort = "Datum";
            MesszyklusGridChart.Columns["ID"].Visible = false;
            MesszyklusGridChart.Columns["Name"].HeaderText = "Messzyklus";
            MesszyklusGridChart.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MesszyklusGridChart.Columns["Name"].ReadOnly = true;
            MesszyklusGridChart.Columns["Datum"].Visible = false;
            MesszyklusGridChart.Columns["Datum"].HeaderText = "Datum";
            MesszyklusGridChart.Columns["Datum"].ReadOnly = true;
        }

        private void PaintChart()
        {
            int i = 0;
            int j = 1;
            foreach (DataGridViewRow Row in MesszyklusGridChart.Rows)
            {
                if (Row.Cells[0].Value != null)
                    if ((bool)(Row.Cells[0] as DataGridViewCheckBoxCell).Value)
                    {
                        chart_Ausgabe.Series[i].Enabled = true;
                        chart_Ausgabe.Series[j].Enabled = true;
                    }
                    else
                    {

                        chart_Ausgabe.Series[i].Enabled = false;
                        chart_Ausgabe.Series[j].Enabled = false;
                    }
                i= i+2;
                j= j+2;
            }
        }

        private void MesszyklusGridChart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            PaintChart();
            chart_Ausgabe.ChartAreas[0].RecalculateAxesScale();
            //chart_Ausgabe.Update();
        }

        private void btnUndoZoom_Click(object sender, EventArgs e)
        {
            chart_Ausgabe.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chart_Ausgabe.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }
    }

}
