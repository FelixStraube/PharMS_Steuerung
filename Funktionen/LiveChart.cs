using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PharMS_Steuerung.Funktionen
{
    class LiveChart
    {
        public DataSet RealGraph = new DataSet("RealTime_Graph");
        public DataRow workRow;
        public DataTable Messungen;
        static List<Array> Speicherliste = new List<Array>();
        public List<int> templist1 = new List<int>();
        public List<int> templist2 = new List<int>();
        static int x = 0;
        static int MessungNR = 0;
 //       public bool live = true;
        public void erfassen ( string Sensor1, string Sensor2, Form1 aktFenster ,bool clear,bool live)
        {    
            
             x = x + 1;
             int intSen1 = Convert.ToInt32(Sensor1);
             int intSen2 = Convert.ToInt32(Sensor2);
             templist1.Add(intSen1);
             templist2.Add(intSen2);
            
            if (live == true){
              
                
                
                if (clear == true) {
                x = 0;
                aktFenster.Messungen_Tabelle(MessungNR, "Messungxy");
                MessungNR = MessungNR + 1;
                
                Speicherliste.Add(listezuArray(templist1,templist2));
                
                   
                aktFenster.Live_Chart_add(x, 0, 0 , clear);
                 
                }
                aktFenster.Live_Chart_add(x,intSen1,intSen2,clear);
           }

            if (live == false) {
                if (clear == true)
                {
                    x = 0;
                    aktFenster.Messungen_Tabelle(MessungNR, "Messungxy");
                    MessungNR = MessungNR + 1;
                    Speicherliste.Add(listezuArray(templist1, templist2));
                }
               
          
            }
        
        }
        public void ausgabeSpeicher(string ListeNummer, Form1 aktFenster)
        {
            int iListe = Convert.ToInt32(ListeNummer);
            if (iListe >= 0)
            {
                // RealGraph.Tables.Add(aktFenster.LiveGrid());

                //   string ausgabe = RealGraph.Tables["Messungen"].Rows[iListe][0].ToString();

                int l = iListe;

                foreach (var series in aktFenster.LiveChart.Series)
                {
                    series.Points.Clear();

                    int Schritlänge = 1;
                    int Lauf = 0;
                    int xAchseSen1 = 0;
                    int xAchseSen2 = 0;
                    int Auswahl = 0;

                    foreach (int i in Speicherliste[l])
                    {

                     if (Lauf == 0)
                        {

                            Lauf = Lauf + 1;
                            Schritlänge = i;
                        }
                        else
                        {
                            if (Auswahl == 0) 
                            {
                                aktFenster.LiveChart.Series[0].Points.AddXY(xAchseSen1 * Lauf, i);
                            xAchseSen1 = xAchseSen1 + 1;
                            Auswahl = 1;
                          }
                        else 
                            {
                                aktFenster.LiveChart.Series[1].Points.AddXY(xAchseSen2 * Lauf, i);
                                xAchseSen2 = xAchseSen2 + 1;
                                Auswahl = 0;
                            }
                        }
                    }
                 }
            }
                

            
        }
        private Array listezuArray (List<int> sensor1, List<int> sensor2){
        int[,] r = new int[sensor1.Count(),2];
        
            
            for (int g = 1; g < sensor1.Count(); g++)
        {
            int i = sensor1[g];
            r[g,0] = i;
                //sensor1[g];
            r[g,1] = sensor2[g];
        } 
        

        return r;
        }


    }
}
