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
    public partial class LiveChartForm : Form
    {
         
        public DataSet TEMP; 
        public Form1 _Form1;
        public LiveChartForm(Form1 MainForm)
        {
            InitializeComponent();
            _Form1 = MainForm;


            int RowCount = MainForm.DBMain.dsPharms.Tables["Messwerte"].Rows.Count;
            string MZ_ID = MainForm.DBMain.dsPharms.Tables["Messwerte"].Rows[RowCount-1].ItemArray[4].ToString();//letzte zeile
        

            DataView dvMesswerte = new DataView(MainForm.DBMain.dsPharms.Tables["Messwerte"]);           
            dvMesswerte.RowFilter = "MZ_ID = " + MZ_ID +" AND MW1 <> -9999.9 AND MW2 <> -9999.9";
            dvMesswerte.Sort = "Datum";
            LiveChart_Ausgabe.DataSource = dvMesswerte;                  
           
            Series serie1 = new Series();
            serie1.Name = "Sensor1";
            serie1.Color = Color.FromArgb(0, 204, 0);
            
            serie1.BorderColor = Color.FromArgb(164, 164, 164);
            serie1.ChartType = SeriesChartType.FastLine;
            serie1.BorderDashStyle = ChartDashStyle.Solid;
            serie1.BorderWidth = 2;
            serie1.ShadowColor = Color.FromArgb(128, 128, 128);
            serie1.ShadowOffset = 1;
            serie1.IsValueShownAsLabel = true;
            serie1.XValueMember = "Datum";
            serie1.YValueMembers = "MW1";
            serie1.Font = new Font("Tahoma", 8.0f);
            serie1.BackSecondaryColor = Color.FromArgb(0, 102, 153);
            serie1.LabelForeColor = Color.FromArgb(100, 100, 100);
            LiveChart_Ausgabe.Series.Add(serie1);

            Series serie2 = new Series();
            serie2.Name = "Sensor2";
            serie2.Color = Color.FromArgb(204, 0, 0);
            serie2.BorderColor = Color.FromArgb(164, 164, 164);
            serie2.ChartType = SeriesChartType.FastLine;
            serie2.BorderDashStyle = ChartDashStyle.Solid;
            serie2.BorderWidth = 2;
            serie2.ShadowColor = Color.FromArgb(128, 128, 128);
            serie2.ShadowOffset = 1;
            serie2.IsValueShownAsLabel = true;
            serie2.XValueMember = "Datum";
            serie2.YValueMembers = "MW2";
            serie2.Font = new Font("Tahoma", 8.0f);
            serie2.BackSecondaryColor = Color.FromArgb(0, 102, 153);
            serie2.LabelForeColor = Color.FromArgb(100, 100, 100);
            LiveChart_Ausgabe.Series.Add(serie2);        
            
            //  databind...        
           
            ChartArea ca = LiveChart_Ausgabe.ChartAreas["ChartArea1"];
         //   ca.AxisY.Maximum = Convert.ToDouble(200);
         //   ca.AxisY.Minimum = Convert.ToDouble(-50);
            ca.AxisX.Title = "[Zeit]";
            ca.AxisY.Title = "[nA]";
            ca.AxisX.LabelStyle.Format = "hh:mm:ss";

            ca.CursorX.IsUserEnabled = true;
            ca.CursorX.IsUserSelectionEnabled = true;

            ca.AxisX.ScaleView.Zoomable = true;
            ca.AxisY.ScaleView.Zoomable = true;
   
            LiveChart_Ausgabe.DataBind();
            tmrPaintChart.Start();

        }      
        public void PaintChart()
        {
            if(LiveChart_Ausgabe != null)
            LiveChart_Ausgabe.DataBind();
        }

        private void LiveChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LiveChart_Ausgabe = null;
            tmrPaintChart.Stop();
        }

        private void tmrPaintChart_Tick(object sender, EventArgs e)
        {
            PaintChart();
        }

  
    }

}
