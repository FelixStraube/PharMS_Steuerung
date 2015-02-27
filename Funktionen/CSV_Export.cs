using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace PharMS_Steuerung.Funktionen
{
    public class CSV_Export
    {

        public void toCSV(DataTable Tabelle_Messwerte, DataTable Tabelle_Messzyklus, string outputFile, SQLMain DBaktuel, List<string> MZ_ID)
        {

            StreamWriter swOut = new StreamWriter(outputFile);
            string sTrenzeichen = ";";
            List<string> Ausgabe = new List<string>();

            Ausgabe.Add(" ");
            Ausgabe.Add(" ");

            for (int i = 0; i <= MZ_ID.Count - 1; i++)
            {
                int Zeit_gesamt = 0;
                int Zeitschritt = 0;

                Ausgabe[1] = Ausgabe[1] + sTrenzeichen + "Zeit [s] " + sTrenzeichen + "Sensor 1 [nA]" + sTrenzeichen + "Sensor 2 [nA]" + sTrenzeichen;
                bool Interwall_bestimmen = true;
                // Anzahl der Festen zeilen -1
                int LängeAktuell = 1;

                int Datenindex = 0;
                foreach (DataRow row in Tabelle_Messzyklus.Rows)
                {
                    if (row["ID"].ToString() == MZ_ID[MZ_ID.Count - i - 1])
                    {
                        string[] Datum = row["Datum"].ToString().Split(' ');

                        Ausgabe[0] = Ausgabe[0] + sTrenzeichen + row["Name"].ToString() + sTrenzeichen + "Datum :" + sTrenzeichen + Datum[0] + sTrenzeichen;


                    }
                }
                foreach (DataRow row in Tabelle_Messwerte.Rows)
                {
                    Datenindex = Datenindex + 1;



                    if (row["MZ_ID"].ToString() == MZ_ID[MZ_ID.Count - i - 1])
                    {

                        LängeAktuell = LängeAktuell + 1;


                        if (Interwall_bestimmen == true)
                        {
                            Zeitschritt = Get_Interval(row["Datum"].ToString(), Tabelle_Messwerte.Rows[Datenindex]["Datum"].ToString());
                            Interwall_bestimmen = false;
                        }
                        Zeit_gesamt = Zeit_gesamt + Zeitschritt;


                        if (Ausgabe.Count > LängeAktuell)
                        {

                            Ausgabe[LängeAktuell] = Ausgabe[LängeAktuell] + sTrenzeichen + Zeit_gesamt.ToString() + sTrenzeichen + row["MW1"].ToString() + sTrenzeichen + row["MW2"].ToString() + sTrenzeichen;

                        }
                        else
                        {
                            Ausgabe.Add(" ");
                            for (int s = 0; i > s; s++)
                            {
                                Ausgabe[LängeAktuell] = Ausgabe[LängeAktuell] + sTrenzeichen + sTrenzeichen + sTrenzeichen + sTrenzeichen;

                            }
                            Ausgabe[LängeAktuell] = Ausgabe[LängeAktuell] + sTrenzeichen + Zeit_gesamt.ToString() + sTrenzeichen + row["MW1"].ToString() + sTrenzeichen + row["MW2"].ToString() + sTrenzeichen;


                        }

                    }

                }

            }

            foreach (string Zeile in Ausgabe)
            {

                swOut.WriteLine(Zeile);

            }
            swOut.Close();

        }

        static int Get_Interval(string Time1, string Time2)
        {

            int Interval = 0;

            string[] Start = Time2.Split(':');
            string[] Start_Stunden = Start[0].Split(' ');

            string[] Ende = Time1.Split(':');
            string[] Ende_Stunden = Ende[0].Split(' ');
           
            //Übergang in nächste Stunde
                if (Convert.ToInt16(Start[1]) >= Convert.ToInt16(Ende[1]))
                {

                    Interval = (Convert.ToInt16(Start[2]) + Convert.ToInt16(Start[1]) * 60) - (Convert.ToInt16(Ende[2]) + Convert.ToInt16(Ende[1]) * 60);
                }
                else
                {
                    Interval = (Convert.ToInt16(Start[2]) + Convert.ToInt16(Start[1]) * 60) - (Convert.ToInt16(Ende[2]) + (Convert.ToInt16(Ende[1]) + 60) * 60);
                }
                    
            return Interval;

        }
    }


}

