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
     
       public DateTime Time = DateTime.Now;
       public DataGrid tet = new DataGrid();
       string Sensor1;
       string Sensor2;
       /// <summary>
       /// Schreibt String in Tabelle(Tab 2) und csv Datei 
       /// </summary>
       /// <param name="Daten">String </param>
       /// <param name="Ausgabefenster">Form1 </param>
       /// 
       public Datenerfassen(String Daten, Form1 Ausgabefenster)
       {
           bool Datei_vorhanden = false;
          
           
               string[] words = Daten.Split(',');
	           foreach (string word in words)
                
                Sensor1 = words[0].Substring(1,words[0].Length-1);
                Sensor2 = words[1];
          
           string Zeit = string.Format("{0:d/M/yyyy HH:mm:ss}", Time);
          
           Ausgabefenster.DatenerfassungTab_Hinzu(Zeit, Sensor1, Sensor2);
           
           
           String BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
           string Filename = "Daten Vom " + string.Format("{0:d/M/yyyy}", Time) + ".txt";
           List<string> dirs = new List<string>(Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory + "Temp\\", "*.txt"));
           foreach (var test in dirs)
           {
               FileInfo x = new FileInfo(test);
               if (x.Name == Filename) {

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
               using (System.IO.StreamWriter file = new System.IO.StreamWriter(BaseDirectory + "Temp\\" + Filename,true))
               {
                 
                   file.WriteLine(Zeit + ";" + Sensor1 + ";" + Sensor2);
                   file.Close();
                       
               }
           }
           

         
    
       }
     
    
    }
}
