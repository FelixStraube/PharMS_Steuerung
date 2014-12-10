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
        public ChartForm(Form1 MainForm,int MZ_ID)
        {
            InitializeComponent();
            _Form1 = MainForm;
            trackBar1.Maximum = MainForm.MesszyklusGrid.RowCount-1;
  //          if (MZ_ID < trackBar1.Maximum) { trackBar1.Value = MZ_ID ; };
           string Temp_MZ_ID = MainForm.MesszyklusGrid.Rows[MZ_ID].Cells["ID"].Value.ToString();


            TEMP = new DataSet();
            TEMP.Tables.Add("Messwerte");

            DataColumn colDecimal = new DataColumn("ID");
            colDecimal.DataType = System.Type.GetType("System.Decimal");
            TEMP.Tables["Messwerte"].Columns.Add(colDecimal);
            
            DataColumn MW1 = new DataColumn("MW1");
            MW1.DataType = System.Type.GetType("System.Double");
            TEMP.Tables["Messwerte"].Columns.Add(MW1);
           
            DataColumn MW2 = new DataColumn("MW2");
            MW2.DataType = System.Type.GetType("System.Double");
            TEMP.Tables["Messwerte"].Columns.Add(MW2);
            
            TEMP.Tables["Messwerte"].Columns.Add("MZ_ID");
           
            
            DataColumn Time = new DataColumn("Time");
            Time.DataType = System.Type.GetType("System.DateTime");
            TEMP.Tables["Messwerte"].Columns.Add(Time);


            DataColumn NormTime = new DataColumn("NormTime");
            NormTime.DataType = System.Type.GetType("System.Double");
            TEMP.Tables["Messwerte"].Columns.Add(NormTime);


            Werte_Graph(MainForm.DBMain.dsPharms.Tables["Messwerte"], Temp_MZ_ID);
             
            chart_Ausgabe.DataSource = TEMP.Tables["Messwerte"];
            
            // chart_Ausgabe.Width = 600;
            // chart_Ausgabe.Height = 350;
    
            //create serie...
            Series serie1 = new Series();
            serie1.Name = "Sensor1";
            serie1.Color = Color.FromArgb(0, 204, 0);
            
            serie1.BorderColor = Color.FromArgb(164, 164, 164);
            serie1.ChartType = SeriesChartType.FastLine;
            serie1.BorderDashStyle = ChartDashStyle.Solid;
            serie1.BorderWidth = 5;
            serie1.ShadowColor = Color.FromArgb(128, 128, 128);
            serie1.ShadowOffset = 1;
            serie1.IsValueShownAsLabel = true;
            serie1.XValueMember = "NormTime";
            serie1.YValueMembers = "MW1";
            serie1.Font = new Font("Tahoma", 8.0f);
            serie1.BackSecondaryColor = Color.FromArgb(0, 102, 153);
            serie1.LabelForeColor = Color.FromArgb(100, 100, 100);
            chart_Ausgabe.Series.Add(serie1);


            Series serie2 = new Series();
            serie2.Name = "Sensor2";
            serie2.Color = Color.FromArgb(204, 0, 0);
            serie2.BorderColor = Color.FromArgb(164, 164, 164);
            serie2.ChartType = SeriesChartType.FastLine;
            serie2.BorderDashStyle = ChartDashStyle.Solid;
            serie2.BorderWidth = 5;
            serie2.ShadowColor = Color.FromArgb(128, 128, 128);
            serie2.ShadowOffset = 1;
            serie2.IsValueShownAsLabel = true;
            serie2.XValueMember = "NormTime";
            serie2.YValueMembers = "MW2";
            serie2.Font = new Font("Tahoma", 8.0f);
            serie2.BackSecondaryColor = Color.FromArgb(0, 102, 153);
            serie2.LabelForeColor = Color.FromArgb(100, 100, 100);
            chart_Ausgabe.Series.Add(serie2);
        
            //  databind...
          //  chart_Ausgabe.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "hh:mm";
            ChartArea ca = chart_Ausgabe.ChartAreas["ChartArea1"];
            ca.AxisY.Maximum = Convert.ToDouble(numericUpDown_ymax.Value);
            ca.AxisY.Minimum = Convert.ToDouble(numericUpDown_ymin.Value);
            ca.AxisX.Title = "[Zeit]";
            ca.AxisY.Title = "[nA]";
            
           // ca.AxisX.IntervalType = DateTimeIntervalType.Minutes;

           // ca.AxisX.IntervalType = ;
            
            
            ca.CursorX.IsUserEnabled = true;
            ca.CursorX.IsUserSelectionEnabled = true;
            
            ca.AxisX.ScaleView.Zoomable = true;
       //     ca.AxisX.Maximum =DateTime.Now.Second ;
                               
            chart_Ausgabe.DataBind();

        }
        void Werte_Graph(DataTable Tabelle, string ID)
        {
            double NormierteZeit = 0;

            TEMP.Tables["Messwerte"].Clear();
            chart_Ausgabe.Titles.Clear();
            string Text = "";


            for (int i = 0; i <= numericUpDownChart.Value - 1; i++)
            {
                if (Convert.ToInt16(ID) - 1 + i < _Form1.MesszyklusGrid.RowCount - 1)
                {
                    Text = Text + " - " + (_Form1.MesszyklusGrid.Rows[Convert.ToInt16(ID) - 1 + i].Cells["Name"].Value.ToString());

                }
                else
                {
                    //if ((Convert.ToInt16(ID) - i - 1) >= 1)
                    //{
                    //    Text = Text +" - "+ (_Form1.MesszyklusGrid.Rows[Convert.ToInt16(ID) - i - 1].Cells["Name"].Value.ToString());
                    //}
                }

              
                int VorZyklus = 0;
                int AktuZyklus = 0;
                int Schleifenzähler = 0 ;
                
                double intervall= 0 ;
                DateTime row_Time = DateTime.Today;
                DateTime row_Vor_Time = DateTime.Today;
                foreach (DataRow TEMP_Row in Tabelle.Rows)
                {
                    DataRow row;                
                    
            
                    
                    if (TEMP_Row.RowState != DataRowState.Deleted)
                {               
                        
                        
                        AktuZyklus = Convert.ToInt16(TEMP_Row["MZ_ID"]);
                       
                        if (Convert.ToDouble(TEMP_Row["MZ_ID"]) == Convert.ToDouble(ID) + i)
                        {
                            
                            row = TEMP.Tables["Messwerte"].NewRow();
                           
                            row["MW1"] = Convert.ToDouble(TEMP_Row["MW1"]);
                       //MIN Max Ausgabe
                       //   Convert.ToDouble(lb_Min);
                       //   if (Convert.ToDouble(lb_Min) > Convert.ToDouble(TEMP_Row["MW1"])) { lb_Min.Text = Convert.ToString(TEMP_Row["MW1"]); }
                       //   if (Convert.ToDouble(lb_Max) < Convert.ToDouble(TEMP_Row["MW1"])) { lb_Max.Text = Convert.ToString(TEMP_Row["MW1"]); }
                            row["MW2"] = Convert.ToDouble(TEMP_Row["MW2"]);
                       
                            row["MZ_ID"] = (TEMP_Row["MZ_ID"]);
                                                  
                            row["Time"] = Convert.ToDateTime(TEMP_Row["Datum"]);
                            row_Time = Convert.ToDateTime(row["Time"]);                            
                            
                            
                            // Messintervall bestimmen 
                             if (Schleifenzähler == 1){
                                 row_Time = Convert.ToDateTime(row["Time"]);
                                 TimeSpan ts = row_Time - row_Vor_Time;
                                 intervall = ts.Seconds;
                                 }
                             if (Schleifenzähler == 0)
                             {
                                 row_Vor_Time = Convert.ToDateTime(row["Time"]); 
                             }
                            //
                             NormierteZeit = NormierteZeit + intervall;
                             row["NormTime"] = NormierteZeit;
                            
                             TEMP.Tables["Messwerte"].Rows.Add(row); 
                             Schleifenzähler = Schleifenzähler + 1;
                        }

                        // Messung Trennstriche
                        if (VorZyklus != AktuZyklus)
                        {
                            StripLine stripline = new StripLine();
                            //stripline.IntervalType = DateTimeIntervalType.Minutes;
                            //stripline.IntervalOffset = row_Time.ToOADate();
                            stripline.IntervalOffset = NormierteZeit;
                            stripline.Interval = 0;
                          
                            stripline.StripWidth = 0.0;
                           
                            stripline.Font = new Font(stripline.Font.FontFamily, 12F);
                            stripline.BorderColor = Color.Red;

                            chart_Ausgabe.ChartAreas["ChartArea1"].AxisX.StripLines.Add(stripline);

                        }
                        //Temp Speicher
                        
                        VorZyklus = AktuZyklus;
                        //VorZyklus = Convert.ToInt16(TEMP_Row["MZ_ID"]);
                    }
                    }
                }

                
                chart_Ausgabe.Titles.Add(Text);
            
        }
    

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            chart_Ausgabe.ChartAreas["ChartArea1"].AxisX.StripLines.Clear();
            Werte_Graph(_Form1.DBMain.dsPharms.Tables["Messwerte"], trackBar1.Value.ToString());
            chart_Ausgabe.DataBind();
        }

        private void numericUpDown_ymax_ValueChanged(object sender, EventArgs e)
        {
            chart_Ausgabe.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(numericUpDown_ymax.Value);
            chart_Ausgabe.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(numericUpDown_ymin.Value);
        }
    }

}
