using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using PharMS_Steuerung;
using System.Drawing;


namespace PharMS_Steuerung.Funktionen
{
    public class Sequenzeditor
    {
        private Dictionary<string, string> dictSequenzBefehleWithOneChar;
        private Dictionary<string, string> dictSequenzBefehleWithTwoChar;
        public List<string> lstCommands;
        private Form1 MainForm;

        public Sequenzeditor(Form1 MainForm)
        {
            dictSequenzBefehleWithOneChar = new Dictionary<string, string>();
            dictSequenzBefehleWithTwoChar = new Dictionary<string, string>();
            lstCommands = new List<string>();
            this.MainForm = MainForm;

            dictSequenzBefehleWithOneChar.Add("X", "Makro  starten mit Sequenznr. ");
            dictSequenzBefehleWithOneChar.Add("x", "Makro  abbrechen mit Sequenznr. ");
            dictSequenzBefehleWithOneChar.Add("W", "Wartezeit in Minuten und Sekunden festlegen");
            dictSequenzBefehleWithOneChar.Add("w", "Wartezeit in Minuten und Sekunden abfragen");
            dictSequenzBefehleWithOneChar.Add("v", "Multiportventil n mit Ventilposition m n,m");
            dictSequenzBefehleWithOneChar.Add("p", "Pumpe Messkreislauf n ein/aus  n,1/0");
            dictSequenzBefehleWithOneChar.Add("f", "Abfrage Füllstandssensor Abfall leer/voll");
            dictSequenzBefehleWithOneChar.Add("A", "Thermostat kalibrieren");
            dictSequenzBefehleWithOneChar.Add("a", "Temperaturabfrage thermische Abfallbehandlung");
            dictSequenzBefehleWithOneChar.Add("T", "Thermostattemperatur einstellen mit -  nn.n - Solltemperatur");
            dictSequenzBefehleWithOneChar.Add("t", "Thermostattemperatur abfragen");
            dictSequenzBefehleWithOneChar.Add("M", "Abfrage aktuelle Sensorstrom [nA]");
            dictSequenzBefehleWithOneChar.Add("G", "Einstellung Verstärkung, Gain 1, 2, 4  Standard ist 2");
            dictSequenzBefehleWithOneChar.Add("U", "Einstelllung der Potentiostatspannung [mV]");
            dictSequenzBefehleWithOneChar.Add("u", "Abfrage der Potentiostatspannung [mV]");
            dictSequenzBefehleWithOneChar.Add("y", "Potenziostat ein/aus");
            //--------------------------------------------------------------------------
            dictSequenzBefehleWithTwoChar.Add("DV", "Dosiererventil n = 1,2 Ventilpositionen  1- Richtung Wasserflasche, 2 – 8 Portventil"); //Messkammer leeren und spülen verwendet Dv ?
            dictSequenzBefehleWithTwoChar.Add("DS", "Geschwindigkeit mit 1 - Vmax, 40 - Vmin");
            dictSequenzBefehleWithTwoChar.Add("DP", "Ansaugmenge (µl)");
            dictSequenzBefehleWithTwoChar.Add("DD", "Ausstossmenge (µl)");
            dictSequenzBefehleWithTwoChar.Add("DA", "Absolutposition (0…500)");
            dictSequenzBefehleWithTwoChar.Add("dn", "Begasung  1-ein, 0-aus");
            dictSequenzBefehleWithTwoChar.Add("on", "Thermostat ein/aus");
            dictSequenzBefehleWithTwoChar.Add("dw", "Begasungsdosierer"); // TODO  Parameter fallen aus den Konzept, seperate Lösung notwendig
            dictSequenzBefehleWithTwoChar.Add("DI", "Was ist das??");

            /* dwOS2A48000IS20A0\n  Z\n    - Kommandostring für Begasungsdosierer
               dw -  Kommando zur Stringeingabe
               O – Ventil auf Ansaugöffnung (rechts)
              S2 – zweitschnellste Geschwindigkeit
              A48000 – Absolutpositionierung 48000 Schritte (Max.)
              I –Ventil auf Ausstoßöffnung (links)
              S20 – Geschwindigkeit 20 (40 Minimum)
              A0  - Absolutpositionierung auf 0*/

            lstCommands.Add("X");
            lstCommands.Add("x");
            lstCommands.Add("W");
            lstCommands.Add("w");
            lstCommands.Add("v");
            lstCommands.Add("p");
            lstCommands.Add("f");
            lstCommands.Add("A");
            lstCommands.Add("a");
            lstCommands.Add("T");
            lstCommands.Add("t");
            lstCommands.Add("M");
            lstCommands.Add("G");
            lstCommands.Add("U");
            lstCommands.Add("u");
            lstCommands.Add("y");
            lstCommands.Add("DV");
            lstCommands.Add("DS");
            lstCommands.Add("DP");
            lstCommands.Add("DD");
            lstCommands.Add("DA");
            lstCommands.Add("dn");
            lstCommands.Add("dw");
            lstCommands.Add("on");
            lstCommands.Add("DI");

            DataGridViewComboBoxColumn colBefehl = (DataGridViewComboBoxColumn)MainForm.SequenzeditorGrid.Columns["colBefehl"];
            foreach (string sCom in lstCommands)
            {
                colBefehl.Items.Add(sCom);
            }
        }

        public void FillGridSequenzEdit()
        {
            Sequenz oSequenz = GetSelectedSequenz();
            MainForm.lbSequenzname.Text = oSequenz.sName;
            string sOut = "";
            int i = 0;
            if (oSequenz == null) throw new System.ArgumentException("Parameter cannot be null", "oSequenz");  //später soll der zustand als anlegen einer neuen sequenz verstanden werden

            MainForm.SequenzeditorGrid.Rows.Clear();


            foreach (string line in oSequenz.stlSequenz)
            {
                if (line == "") continue;

                MainForm.SequenzeditorGrid.Rows.Add();
                DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)MainForm.SequenzeditorGrid.Rows[i].Cells[0];
                sOut = "";

                if (line.Length != 1) dictSequenzBefehleWithTwoChar.TryGetValue(line.Substring(0, 2), out sOut);
                else sOut = null;

                if (sOut == null)
                {
                    dictSequenzBefehleWithOneChar.TryGetValue(line.Substring(0, 1), out sOut);
                    cbCell.Value = line.Substring(0, 1);
                    MainForm.SequenzeditorGrid.Rows[i].Cells[1].Value = line.Substring(1);
                }
                else
                {
                    cbCell.Value = line.Substring(0, 2);
                    MainForm.SequenzeditorGrid.Rows[i].Cells[1].Value = line.Substring(2);
                }

                if (MainForm.SequenzeditorGrid.Rows[i].Cells[1].Value.ToString() != "*")
                {
                    MainForm.SequenzeditorGrid.Rows[i].Cells[1].ReadOnly = true;
                    MainForm.SequenzeditorGrid.Rows[i].Cells[1].Style.BackColor = Color.Gray;
                }
                else
                {
                    MainForm.SequenzeditorGrid.Rows[i].Cells[1].Style.BackColor = Color.RosyBrown;
                    MainForm.Uebertragen.Enabled = false;
                }

                MainForm.SequenzeditorGrid.Rows[i].Cells[2].Value = sOut;


                i++;
            }
        }

        public void FillGridSequenz()
        {
            int i = 0;
            MainForm.SequenzenGrid.Rows.Clear();

            foreach (Sequenz oSequenz in MainForm.lstSequenz)
            {

                MainForm.SequenzenGrid.Rows.Add();
                MainForm.SequenzenGrid.Rows[i].Cells[0].Value = oSequenz.sName;
                MainForm.SequenzenGrid.Rows[i].Cells[1].Value = (oSequenz.iSpeicherplatz == -999) ? "" : oSequenz.iSpeicherplatz.ToString();
                i++;
            }
        }
        public Sequenz GetSelectedSequenz()
        {
            foreach (Sequenz oSequenz in MainForm.lstSequenz)
            {
                if (MainForm.AblaufListe.SelectedItem.ToString() == oSequenz.sName) return oSequenz;
            }
            return null;

        }

    }
}
