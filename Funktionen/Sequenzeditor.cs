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
{//Für alle DataGrids
    public class Sequenzeditor
    {
        public Dictionary<string, string> dictSequenzBefehle;

        public List<string> lstCommands;
        private Form1 MainForm;

        public Sequenzeditor(Form1 MainForm)
        {
            dictSequenzBefehle = new Dictionary<string, string>();

            lstCommands = new List<string>();
            this.MainForm = MainForm;

            dictSequenzBefehle.Add("X", "Makro  starten mit Sequenznr. ");
            dictSequenzBefehle.Add("x", "Makro  abbrechen mit Sequenznr. ");
            dictSequenzBefehle.Add("W", "Wartezeit in Minuten und Sekunden festlegen");
            dictSequenzBefehle.Add("w", "Wartezeit in Minuten und Sekunden abfragen");
            dictSequenzBefehle.Add("v", "Multiportventil n mit Ventilposition m n,m");
            dictSequenzBefehle.Add("p", "Pumpe Messkreislauf n ein/aus  n,1/0");
            dictSequenzBefehle.Add("f", "Abfrage Füllstandssensor Abfall leer/voll");
            dictSequenzBefehle.Add("A", "Thermostat kalibrieren");
            dictSequenzBefehle.Add("a", "Temperaturabfrage thermische Abfallbehandlung");
            dictSequenzBefehle.Add("T", "Thermostattemperatur einstellen mit -  nn.n - Solltemperatur");
            dictSequenzBefehle.Add("t", "Thermostattemperatur abfragen");
            dictSequenzBefehle.Add("M", "Abfrage aktuelle Sensorstrom [nA]");
            dictSequenzBefehle.Add("G", "Einstellung Verstärkung, Gain 1, 2, 4  Standard ist 2");
            dictSequenzBefehle.Add("U", "Einstelllung der Potentiostatspannung [mV]");
            dictSequenzBefehle.Add("u", "Abfrage der Potentiostatspannung [mV]");
            dictSequenzBefehle.Add("y", "Potenziostat ein/aus");
            dictSequenzBefehle.Add("d", "Begaser ein/aus");
            dictSequenzBefehle.Add("o", "Thermostat ein/aus");
            //--------------------------------------------------------------------------
            dictSequenzBefehle.Add("DV", "Dosiererventil n = 1,2 Ventilpositionen  1- Richtung Wasserflasche, 2 – 8 Portventil"); //Messkammer leeren und spülen verwendet Dv ?
            dictSequenzBefehle.Add("DS", "Geschwindigkeit mit 1 - Vmax, 40 - Vmin");
            dictSequenzBefehle.Add("DP", "Ansaugmenge (µl)");
            dictSequenzBefehle.Add("DD", "Ausstossmenge (µl)");
            dictSequenzBefehle.Add("DA", "Absolutposition (0…500)");
            dictSequenzBefehle.Add("on", "Thermostat ein/aus");
            dictSequenzBefehle.Add("dw", "Begasungsdosierer"); // TODO  Parameter fallen aus den Konzept, seperate Lösung notwendig
            dictSequenzBefehle.Add("DI", "Was ist das??");

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
            lstCommands.Add("d");
            lstCommands.Add("o");
            lstCommands.Add("DV");
            lstCommands.Add("DS");
            lstCommands.Add("DP");
            lstCommands.Add("DD");
            lstCommands.Add("DA");
            lstCommands.Add("dw");
            lstCommands.Add("on");
            lstCommands.Add("DI");
        }

        public void FillGridSequenzEdit()
        {
            MainForm.SequenzeditorGrid.Columns.Clear();
            DataView dvSequenzEdit = new DataView(MainForm.DBMain.dsPharms.Tables["SequenzEdit"]);
            if (MainForm.AblaufListe.SelectedItem != null)
            {
                int ID = Convert.ToInt32(MainForm.AblaufListe.SelectedValue);
                dvSequenzEdit.RowFilter = "S_ID =" + ID.ToString();
                dvSequenzEdit.Sort = "Reihenfolge";

                DataGridViewTextBoxColumn colErklaerung = new DataGridViewTextBoxColumn();
                colErklaerung.Name = "Erklärung";
                colErklaerung.HeaderText = "Erklärung";

                DataGridViewComboBoxColumn ComboBoxColumn = new DataGridViewComboBoxColumn();
                ComboBoxColumn.Name = "Befehl";
                ComboBoxColumn.HeaderText = "Befehl";
                ComboBoxColumn.DataPropertyName = "Befehl";
                ComboBoxColumn.ValueType = typeof(String);
                ComboBoxColumn.DataSource = lstCommands;

                MainForm.SequenzeditorGrid.Columns.Add(colErklaerung);
                MainForm.SequenzeditorGrid.Columns.Add(ComboBoxColumn);
                MainForm.SequenzeditorGrid.AutoGenerateColumns = true;
                MainForm.SequenzeditorGrid.DataSource = dvSequenzEdit;
                MainForm.SequenzeditorGrid.Columns["ID"].Visible = false;
                MainForm.SequenzeditorGrid.Columns["Vorlage"].Visible = false;
                MainForm.SequenzeditorGrid.Columns["S_ID"].Visible = false;
                // MainForm.SequenzeditorGrid.Columns["Reihenfolge"].Visible = false;
                MainForm.SequenzeditorGrid.Columns["S_ID"].CellTemplate.Value = ID.ToString();
                MainForm.SequenzeditorGrid.Columns["Reihenfolge"].CellTemplate.Value = MainForm.SequenzeditorGrid.RowCount;
                MainForm.SequenzeditorGrid.Columns["Parameter"].HeaderText = "Parameter";


                MainForm.SequenzeditorGrid.Columns["Erklärung"].DisplayIndex = 3;

                MainForm.SequenzeditorGrid.Columns["Erklärung"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               
            }

        }

        public void LoadGridSequenz()
        {
            String[] cmbWerte = new String[] { " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18" };
            DataGridViewComboBoxColumn ComboBoxColumn = new DataGridViewComboBoxColumn();
            ComboBoxColumn.Name = "Speicherplatz";
            ComboBoxColumn.HeaderText = "Speicherplatz";
            ComboBoxColumn.DataPropertyName = "Speicherplatz";
            ComboBoxColumn.ValueType = typeof(String);
            ComboBoxColumn.DataSource = cmbWerte;


            MainForm.SequenzenGrid.Columns.Add(ComboBoxColumn);
            MainForm.SequenzenGrid.AutoGenerateColumns = true;
            MainForm.SequenzenGrid.DataSource = MainForm.DBMain.dsPharms.Tables["Sequenzen"];
            MainForm.SequenzenGrid.Columns["ID"].Visible = false;
            MainForm.SequenzenGrid.Columns["Name"].HeaderText = "Sequenz";
            MainForm.SequenzenGrid.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void FillGridMaster()
        {
            String[] cmbWerte = new String[] { " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18" };
            DataGridViewComboBoxColumn ComboBoxColumn1 = new DataGridViewComboBoxColumn();
            ComboBoxColumn1.Name = "Speicherplatz";
            ComboBoxColumn1.HeaderText = "Speicherplatz";
            ComboBoxColumn1.DataPropertyName = "Speicherplatz";
            ComboBoxColumn1.ValueType = typeof(String);
            ComboBoxColumn1.DataSource = cmbWerte;

            DataGridViewComboBoxColumn ComboBoxColumn2 = new DataGridViewComboBoxColumn();
            ComboBoxColumn2.Name = "Sequenz";
            ComboBoxColumn2.HeaderText = "Sequenz";
            ComboBoxColumn2.DataPropertyName = "S_ID";
            ComboBoxColumn2.ValueType = typeof(int);
            ComboBoxColumn2.DisplayMember = "Name";
            ComboBoxColumn2.ValueMember = "ID";
            ComboBoxColumn2.DataSource = MainForm.DBMain.dsPharms.Tables["Sequenzen"];

            MainForm.MasterGrid.Columns.Add(ComboBoxColumn2);
            MainForm.MasterGrid.Columns.Add(ComboBoxColumn1);
            MainForm.MasterGrid.AutoGenerateColumns = true;
            MainForm.MasterGrid.DataSource = MainForm.DBMain.dsPharms.Tables["Masterablauf"];
            MainForm.MasterGrid.Columns["ID"].Visible = false;
            MainForm.MasterGrid.Columns["Name"].Visible = false;
            // MainForm.MasterGrid.Columns["Reihenfolge"].Visible = false;

            MainForm.MasterGrid.Columns["Sequenz"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
