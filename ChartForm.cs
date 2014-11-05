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





            Werte_Graph(MainForm.DBMain.dsPharms.Tables["Messwerte"], Temp_MZ_ID);
           
            
            
            chart_Ausgabe.DataSource = TEMP.Tables["Messwerte"];
            _Form1 = MainForm;
            chart_Ausgabe.Width = 600;
            chart_Ausgabe.Height = 350;
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
            serie1.XValueMember = "Time";
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
            serie2.XValueMember = "Time";
            serie2.YValueMembers = "MW2";
            serie2.Font = new Font("Tahoma", 8.0f);
            serie2.BackSecondaryColor = Color.FromArgb(0, 102, 153);
            serie2.LabelForeColor = Color.FromArgb(100, 100, 100);
            chart_Ausgabe.Series.Add(serie2);
            
            
            
            
            //create chartareas...
            //ChartArea ca = new ChartArea();
            //ca.Name = "ChartArea2";
            //ca.BackColor = Color.White;
            //ca.BorderColor = Color.FromArgb(26, 59, 105);
            //ca.BorderWidth = 0;
            //ca.BorderDashStyle = ChartDashStyle.Solid;
            //ca.AxisX = new Axis();
            //ca.AxisY = new Axis();
            //ca.AxisX.LabelStyle.Format = "ss";
            //chart_Ausgabe.ChartAreas.Add(ca);
           
            //  databind...
            chart_Ausgabe.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "mm:ss";
            ChartArea ca = chart_Ausgabe.ChartAreas["ChartArea1"];
       //     ca.AxisX.Maximum =DateTime.Now.Second ;
           
            
            
            chart_Ausgabe.DataBind();

            
            

        }
        void Werte_Graph(DataTable Tabelle ,string ID)
        {

            TEMP.Tables["Messwerte"].Clear();
         
            for ( int i = 0 ; i <= numericUpDownChart.Value-1; i++){
              
               foreach (DataRow TEMP_Row in Tabelle.Rows)
               {

                   if (Convert.ToDouble(TEMP_Row["MZ_ID"]) == Convert.ToDouble(ID)+i)
                   {
                       DataRow row;
                       row = TEMP.Tables["Messwerte"].NewRow();
                       row["MW1"] = Convert.ToDouble(TEMP_Row["MW1"]);
                       Console.WriteLine(row["MW1"]);
                       row["MW2"] = Convert.ToDouble(TEMP_Row["MW2"]);
                       Console.WriteLine(row["MW2"]);
                       row["MZ_ID"] = (TEMP_Row["MZ_ID"]);
                       row["Time"] = Convert.ToDateTime(TEMP_Row["Datum"]);
                       Console.WriteLine(row["Time"]);
                       TEMP.Tables["Messwerte"].Rows.Add(row);
                   }
               }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
            Werte_Graph(_Form1.DBMain.dsPharms.Tables["Messwerte"], trackBar1.Value.ToString());
            chart_Ausgabe.DataBind();
        }
    }

}
