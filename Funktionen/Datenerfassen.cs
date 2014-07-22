/*Ausgab der Daten in eine Tabelle
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;


namespace PharMS_Steuerung.Funktionen
{
    class Datenerfassen
    {

       // public DateTime Time = DateTime.Now;
        public DataGrid tet = new DataGrid();
        public DataTable TableMeasurements = new DataTable();
        string Sensor1;
        string Sensor2;
        private System.IO.StreamWriter file;
        /// <summary>
        /// Schreibt String in Tabelle(Tab 2) und csv Datei 
        /// </summary>
        /// <param name="Daten">String </param>
        /// <param name="Ausgabefenster">Form1 </param>
        /// 
        public Datenerfassen()
        {
            TableMeasurements.Columns.Add("Time", typeof(DateTime));
            TableMeasurements.Columns.Add("Sec", typeof(int));
            TableMeasurements.Columns.Add("Sensor1", typeof(Double));
            TableMeasurements.Columns.Add("Sensor2", typeof(Double));

            /*bool Datei_vorhanden = false;


            string[] words = Daten.Split(',');
            //string[] words = Daten.Split(';');
            foreach (string word in words)

                Sensor1 = words[0].Substring(1, words[0].Length - 1);
            Sensor2 = words[1].Substring(1, words[1].Length - 1);
            //Sensor1 = words[1];
            // Sensor2 = words[2];

            string Zeit = string.Format("{0:d/M/yyyy HH:mm:ss}", Time);
            //string Zeit = words[0];

            Ausgabefenster.DatenerfassungTab_Hinzu(Zeit, Sensor1, Sensor2);

            LiveChart Ausgabe = new LiveChart();

            // Ausgabe zu Graphen
            Ausgabe.erfassen(Sensor1, Sensor2, Ausgabefenster, false, true);


            String BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string Filename = "Daten Vom " + string.Format("{0:d/M/yyyy}", Time) + ".txt";
            List<string> dirs = new List<string>(Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory + "Temp\\", "*.txt"));
            foreach (var test in dirs)
            {
                FileInfo x = new FileInfo(test);
                if (x.Name == Filename)
                {

                    Datei_vorhanden = true;
                }
            }
            if (Datei_vorhanden == false)
            {
                System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "Temp\\" + Filename);

                Datei_vorhanden = true;

            }


            if (Datei_vorhanden == true)
            {

                try { file = new System.IO.StreamWriter(BaseDirectory + "Temp\\" + Filename, true); }
                catch { return; };
                {

                    file.WriteLine(Zeit + ";" + Sensor1 + ";" + Sensor2);
                    file.Close();

                }
            }*/
        }

        public void BuildSource(String Daten)
        {
            string[] words = Daten.Split(',');
            string Sensor1a = words[0].Substring(1, words[0].Length - 1);
            Sensor1a = Sensor1a.Replace(".", ",");
            string Sensor2b = words[1].Substring(1, words[1].Length - 1);
            Sensor2b = Sensor2b.Replace(".", ",");

            TableMeasurements.Rows.Add(DateTime.Now, Convert.ToDouble(Sensor1a), Convert.ToDouble(Sensor2b));

        }
    }

}
