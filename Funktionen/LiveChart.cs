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
     //   public DataRow workRow;
      //  public DataTable Messungen;
        static List<Array> Speicherliste = new List<Array>();
        static List<decimal> templist1 = new List<decimal>();
        static List<decimal> templist2 = new List<decimal>();
        static int x = 0;
        static int MessungNR = 0;


 //       public bool live = true;
        public void erfassen ( string Sensor1, string Sensor2, Form1 aktFenster ,bool clear,bool live)
        {    
            
             x = x + 1;
             decimal intSen1 = 0;
             decimal intSen2 = 0;
             string Ganzzahl="";
             string Nachkomma="";
             if (Sensor1 != "--------")
             {
                 if (Sensor1.Substring(0, 1) == "-")
                 {
                     string[] words = Sensor1.Split('.');
                     foreach (string word in words)

                     Ganzzahl = words[0].Substring(1, words[0].Length - 1);
                     if (Ganzzahl != "")
                     {
                         Nachkomma = words[1];
                     }
                     intSen1 = Convert.ToDecimal(Ganzzahl+","+Nachkomma);

                     intSen1 = intSen1 * -1;

                 }
                 else
                 {
                     string[] words = Sensor1.Split('.');
                     foreach (string word in words)

                         Ganzzahl = words[0].Substring(1, words[0].Length - 1);
                     if (Ganzzahl != "")
                     {
                         Nachkomma = words[1];  
                         intSen1 = Convert.ToDecimal(Ganzzahl + "," + Nachkomma);
                     }

                   

                     
                 }
             }
             else
             {
               //  return;
             }

             if (Sensor2 != "---------")
             {
                if (Sensor2.Substring(0, 1) == "-")
                 {
                     string[] words = Sensor2.Split('.');
                     foreach (string word in words)

                     Ganzzahl = words[0].Substring(1, words[0].Length - 1);
                     if (words.Count() > 1)
                     {
                         Nachkomma = words[1];

                         intSen2 = Convert.ToDecimal(Ganzzahl + "," + Nachkomma);
                     }

                     intSen2 = intSen2 * -1;                     
                 }
                 else
                 {
                     string[] words = Sensor2.Split('.');
                     foreach (string word in words)

                         Ganzzahl = words[0].Substring(1, words[0].Length - 1);
                     if (Ganzzahl != "")
                     {
                         Nachkomma = words[1];
                         intSen2 = Convert.ToDecimal(Ganzzahl + "," + Nachkomma);
                     }

                     

                 }
             }
             else { //return; 
                  }

            templist1.Add(intSen1);
            templist2.Add(intSen2);
            
            if (live == true){
              
                
                
                if (clear == true) {
                x = 0;
                aktFenster.Messungen_Tabelle(MessungNR, "Messungxy");
                MessungNR = MessungNR + 1;
                
                Speicherliste.Add(listezuArray(templist1,templist2));
                templist1.Clear();
                templist2.Clear();
                   
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
                    templist1.Clear();
                    templist2.Clear();
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

                    decimal Schritlänge = 1*aktFenster.numeric_Intervall.Value;
                    int Lauf = 0;
                    int xAchseSen1 = 0;
                    int xAchseSen2 = 0;
                    int Auswahl = 0;

                    foreach (decimal i in Speicherliste[l])
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
        private Array listezuArray(List<decimal> sensor1, List<decimal> sensor2)
        {
            decimal[,] r = new decimal[sensor1.Count(), 2];
        
            
            for (int g = 1; g < sensor1.Count()-1; g++)
        {
            decimal i = sensor1[g];
            r[g,0] = i;
                //sensor1[g];
            r[g,1] = sensor2[g];
        } 
        

        return r;
        }


    }
}
