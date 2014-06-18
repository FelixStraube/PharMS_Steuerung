using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using PharMS_Steuerung.Funktionen;



namespace PharMS_Steuerung
{
    public partial class Form1 : Form
    { // das ist ein test VS
        static COM Comschnitstelle;
        string ablauf;
        public bool Connection;
        public string Name;
        public int Durchläufe;
        public bool Abbruch;
        public int Prozessstand;
        static int ende;
        public bool SchleifenStopp = false;
        private int i = 1;
        static System.Windows.Forms.Timer Zeitsteuerung = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;
        public List<Sequenz> lstSequenz;
        public Sequenzeditor oSequenzeditor;
        bool bDBIsOpen = false;
        bool bDBIsOpening = false;
        string sDBPath;
        string sDBName;
        public int maxObjectKey;
        public List<int> lstMaster = new List<int>();


        public Form1()
        {
            InitializeComponent();

        }

        private void Uebertragen_Click(object sender, EventArgs e)
        {

            string Name = AblaufListe.SelectedItem.ToString();

            CfgFile test = new CfgFile(Name);
            List<String> lines = new List<string>();
            lines = test.Ausgabe(Name);

            //  Console.WriteLine("Incoming Data:" + lines[0]);
            int count = lines.Count;
            ablauf = "";
            for (int i = 1; i < count; i++)
            {
                if (lines[i] == "") { }
                else ablauf = ablauf + ";" + lines[i];

            }

            // Console.WriteLine("Incoming Data:" + "Y" + cmbSpeicherplatz.SelectedItem.ToString() + ablauf);

            //Comschnitstelle.COMSender("Y" + cmbSpeicherplatz.SelectedItem.ToString() + ablauf);



        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Comschnitstelle = new COM(this);
            panel1.BackColor = System.Drawing.Color.Green;
            Connection = true;

        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            Comschnitstelle.COMDisconnect();
            panel1.BackColor = System.Drawing.Color.Red;
            Connection = false;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                Exporting Save = new Exporting(DatenerfassungTab, sfd.FileName); // Here dataGridview1 is your grid view name 
            }

        }

        public bool DatenerfassungTab_Hinzu(string Time, string Daten, string Daten2)
        {
            if (this.InvokeRequired)
            {

                return (bool)this.Invoke((Func<string, string, string, bool>)DatenerfassungTab_Hinzu, Time, Daten, Daten2);

            }
            DataGridViewRow row = (DataGridViewRow)DatenerfassungTab.Rows[0].Clone();
            row.Cells[0].Value = Time;
            row.Cells[1].Value = Daten;
            row.Cells[2].Value = Daten2;
            DatenerfassungTab.Rows.Add(row);
            return true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Connection == true)
            {
                change_Label("In Arbeit", label6);
                Comschnitstelle.COMSender("X" + cmbSpeicherplatzTest.SelectedItem.ToString());

                // label6.Text = "In Arbeit";

            }
            else
            {
                MessageBox.Show("COM nicht Verbunden");
            }
        }

        private void NOTSTOPP_Click(object sender, EventArgs e)
        {
            change_progressBar(-1, 0, progressBar1);
            Abbruch = true;
            Comschnitstelle.COMNotSender("x");

        }

        public bool change_Label(string Text, Label Textlabel)
        {
            if (this.InvokeRequired)
            {

                return (bool)this.Invoke((Func<string, Label, bool>)change_Label, Text, Textlabel);

            }
            Textlabel.Text = Text;


            return true;
        }

        public bool change_progressBar(int aktuell, int Stepp, ProgressBar statusleist)
        {
            if (this.InvokeRequired)
            {

                return (bool)this.Invoke((Func<int, int, ProgressBar, bool>)change_progressBar, aktuell, Stepp, statusleist);

            }
            statusleist.Maximum = Stepp;
            statusleist.Step = 1;
            if (aktuell == 0) { statusleist.Value = 0; };
            statusleist.PerformStep();
            if (aktuell == -1) { statusleist.Value = 0; };



            return true;
        }

        private void AblaufStart_Click(object sender, EventArgs e)
        {
            Abbruch = false;
            Durchläufe = Convert.ToInt32(numericUpDown1.Value);
            if (Masterablauf.SelectedItem == null) { return; };
            Name = Masterablauf.SelectedItem.ToString();

            Thread threadAblaufStart = new Thread(new ThreadStart(Execute_Ablauf));
            threadAblaufStart.Start();

        }

        public void Execute_Ablauf()
        {
            List<String> newlines = new List<string>();


            CfgFile test = new CfgFile(Name);

            //  Console.WriteLine("Incoming Data:" + lines[0]);
            newlines = test.Ausgabe("Master\\" + Name);
            int count = newlines.Count;
            change_progressBar(-1, 0, progressBar1);
            for (int z = 0; z < Durchläufe; z++)
            {

                for (int i = 1; i < count; i++)
                {

                    Boolean Lauf = true;
                    do
                    {
                        if (newlines[i] != "")
                        {
                            Lauf = Comschnitstelle.COMAblaufSender("X" + newlines[i]);
                            Console.WriteLine("Line: " + i + ";" + count + ";" + "X" + newlines[i]);
                        };
                        if (Abbruch == true) { break; }

                        System.Threading.Thread.Sleep(1000);

                    } while (Lauf == false);

                }

                change_progressBar(z, Durchläufe, progressBar1);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!bDBIsOpen)
            {
                ImportStripMenuItem2.Enabled = false;
                speichernToolStripMenuItem.Enabled = false;
            }

            bool OrdnerExisitiert = Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Abläufe");      //TODO Test und Temp?     
            if (!OrdnerExisitiert)
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Abläufe");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Abläufe\\Master");
            }
            List<string> dirs = new List<string>(Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory + "Abläufe\\", "*.txt"));
            List<string> dirAblauf = new List<string>(Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory + "Abläufe\\Master\\", "*.txt"));

            oSequenzeditor = new Sequenzeditor(this);
            /*
            lstSequenz = new List<Sequenz>();

            AblaufListe.Items.Clear();
            //   AblaufListe.Items.Add("ROOT");
            foreach (var dir in dirs)
            {
                FileInfo x = new FileInfo(dir);
                AblaufListe.Items.Add(x.Name);
                //---------------- neuer Ansatz
                lstSequenz.Add(new Sequenz(x));
            }*/

            Masterablauf.Items.Clear();
            foreach (var dir in dirAblauf)
            {
                FileInfo x = new FileInfo(dir);

                Masterablauf.Items.Add(x.Name);

            }


        }

        private void Console_Senden_Click(object sender, EventArgs e)
        {
            Abbruch = true;
            Comschnitstelle.COMSender(Console_Eingabe.Text);
            //    Funktionen.Consolen_LOG Ausgabe = new Funktionen.Consolen_LOG(Console_Eingabe.Text, this);


        }

        private void Man_Messung_Click(object sender, EventArgs e)
        {
            Comschnitstelle.COMSender("U" + numericZellspannung.Value);
            int n = Convert.ToInt32(numeric_Intervall.Value);
            ende = Convert.ToInt32(numeric_Messdauer.Value);
            ende = ende * 60 / n;
            if (i == 1)
            {

                Zeitsteuerung.Tick += new EventHandler(TimerEventProcessor);
            };
            i = i + 1;
            alarmCounter = 1;
            Zeitsteuerung.Interval = n * 1000;
            Zeitsteuerung.Start();
        }

        private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {

            Zeitsteuerung.Stop();
            // Displays a message box asking whether to continue running the timer.

            if (alarmCounter <= ende)
            {
                Console.WriteLine("teste" + alarmCounter + ":" + ende);
                // Restarts the timer and increments the counter.
                Comschnitstelle.COMSender("M");
                alarmCounter += 1;
                Zeitsteuerung.Enabled = true;
            }
            else
            {
                Datenerfassen test = new Datenerfassen("---------,---------", Comschnitstelle.tempForm);
                // Stops the timer.
                exitFlag = true;

            }
        }

        private void Messung_Stopp_Click(object sender, EventArgs e)
        {
            ende = 0;
            SchleifenStopp = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { radioButton2.Checked = false; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) { radioButton1.Checked = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Comschnitstelle.COMSender("X01");
        }

        private void AblaufListe_SelectedValueChanged(object sender, EventArgs e)
        {
            oSequenzeditor.FillGridSequenzEdit();
        }

        private void datenbankÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> stlAllSequenz = new List<string>();
            if (openDatabaseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CfgFile oCfgFile = new CfgFile(openDatabaseDialog.FileName);
                stlAllSequenz = oCfgFile.Ausgabe(); //Gibt die aktuell eingelesene Datei aus
                sDBPath = openDatabaseDialog.FileName;

                bDBIsOpening = true;
                maxObjectKey = 0;
                extractDatabase(stlAllSequenz);
                bDBIsOpen = true;
                ImportStripMenuItem2.Enabled = true;
                speichernToolStripMenuItem.Enabled = true;
                oSequenzeditor.FillGridSequenz();
                oSequenzeditor.FillGridMaster();
                bDBIsOpening = false;
            }
        }

        private void extractDatabase(List<string> DB)
        {
            lstSequenz = new List<Sequenz>();
            Sequenz oSequenz = null;
            bool bNewSequenz = false, bSpeicherplatz = false, bMaster = false;
            sDBName = DB[0];
            DB.RemoveAt(0);
            foreach (string line in DB)
            {
                if (line == "@//@")
                {
                    bNewSequenz = true;
                    continue;
                }

                if (bNewSequenz && line != "" && line != "/*M*/")
                {
                    bNewSequenz = false;
                    lstSequenz.Add(oSequenz = new Sequenz());
                    oSequenz.ObjectKey = maxObjectKey++;
                    oSequenz.sName = line;
                    oSequenz.sDBName = sDBName;
                    AblaufListe.Items.Add(line);
                    continue;
                }

                if (line == "/*-*/")
                {
                    bSpeicherplatz = true;
                    continue;
                }

                if (bSpeicherplatz)
                {
                    bSpeicherplatz = false;
                    oSequenz.iSpeicherplatz = Convert.ToInt32(line);
                    continue;
                }

                if (line == "/*M*/")//Dadurch das der Master am ende der Datei geschrieben wird ist es egal das der bMaster immer true ist
                {
                    bNewSequenz = false;
                    bMaster = true;
                    continue;
                }

                if (bMaster)
                {
                    lstMaster.Add(Convert.ToInt32(line));
                    continue;
                }

                if (oSequenz != null && line != "")
                {
                    if (line.Contains("*")) oSequenz.bIsTemplate = true;
                    oSequenz.stlSequenz.Add(line);
                }


            }
        }

        private void ImportStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (openDatabaseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo x = new FileInfo(openDatabaseDialog.FileName);
                lstSequenz.Add(new Sequenz(x));
                lstSequenz[lstSequenz.Count - 1].ObjectKey = maxObjectKey++;
                lstSequenz[lstSequenz.Count - 1].sDBName = sDBName;
                AblaufListe.Items.Add(x.Name);
                oSequenzeditor.FillGridSequenz();
                // SequenzenGrid.RowsAdded += SequenzenGrid_RowsAdded;
            }

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Close();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDatabase();
        }

        private void SaveDatabase()
        {
            using (FileStream stream = File.Open(sDBPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.WriteLine(lstSequenz[0].sDBName);
                    foreach (Sequenz oSequenz in lstSequenz)
                    {
                        sw.WriteLine("@//@");
                        sw.WriteLine(oSequenz.sName);
                        foreach (string line in oSequenz.stlSequenz)
                        {
                            sw.WriteLine(line);
                        }
                        sw.WriteLine("/*-*/");
                        sw.WriteLine(oSequenz.iSpeicherplatz.ToString());
                    }
                    sw.WriteLine("@//@");
                    sw.WriteLine("/*M*/");
                    foreach (int iMaster in lstMaster)
                    {
                        sw.WriteLine(iMaster.ToString());
                    }

                }
            }
        }

        private void btnSaveOneSequenz_Click(object sender, EventArgs e)
        {
            if (txtNewName.TextLength == 0)
            {
                MessageBox.Show("Bitte geben Sie einen Namen für die neue Sequenz an");
                return;
            }

            lstSequenz.Add(new Sequenz());
            lstSequenz[lstSequenz.Count - 1].ObjectKey = maxObjectKey++;
            lstSequenz[lstSequenz.Count - 1].sDBName = sDBName;
            lstSequenz[lstSequenz.Count - 1].sName = txtNewName.Text;
            AblaufListe.Items.Add(lstSequenz[lstSequenz.Count - 1].sName);

            for (int i = 0; i < SequenzeditorGrid.RowCount - 1; i++)
            {
                lstSequenz[lstSequenz.Count - 1].stlSequenz.Add(SequenzeditorGrid.Rows[i].Cells[0].Value.ToString() + SequenzeditorGrid.Rows[i].Cells[1].Value.ToString());
            }
            oSequenzeditor.FillGridSequenz();
            oSequenzeditor.FillGridSequenzEdit();
        }


        private void SequenzenGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int i = 0;
                //<<<<<<< HEAD
                foreach (Sequenz oSequenz in lstSequenz)
                {
                    //<<<<<<< HEAD
                    if (SequenzenGrid.Rows[e.RowIndex].Cells[0].Value.ToString() == oSequenz.sName)
                    {
                        foreach (string line in oSequenz.stlSequenz)
                        {
                            if (line == "") continue;
                            ablauf = ablauf + ";" + line;
                            //=======
                            /* foreach (Sequenz oSequenz in lstSequenz)
                             {

                                 if (SequenzenGrid.Rows[e.RowIndex].Cells[0].Value.ToString() == oSequenz.sName)
                                 {
                                     foreach (string line in oSequenz.stlSequenz)
                                     {
                                         if (line == "") continue;
                                         ablauf = ablauf + ";" + line;
            >>>>>>> 246326ef06412631c989eda2d776e62fc04eb8ef
                            
                            
                                     }
                                      Comschnitstelle.COMSender("Y" + oSequenz.iSpeicherplatz.ToString() + ablauf);
                                      Console.WriteLine("Incoming Data:" + "Y" + oSequenz.iSpeicherplatz.ToString() + ablauf);
                                 }
                             }

            <<<<<<< HEAD
                            if (e.ColumnIndex == 3)
                            {
                                //Platzhalter für Startbutton im Grid
            //=======
                             //   if (SequenzenGrid.Rows[e.RowIndex].Cells[3].Value.ToString() == oSequenz.ObjectKey.ToString()) break;
                              //  i++;
            //>>>>>>> dd2403d0287f827b4b3706b139d95ddaccb92d3b
                            }
            =======
                             if (e.ColumnIndex == 3)
                             {
                                 //Platzhalter für Startbutton im Grid

                                 if (SequenzenGrid.Rows[e.RowIndex].Cells[3].Value.ToString() == oSequenz.ObjectKey.ToString()) break;
                                 i++;

                             }*/
                            //>>>>>>> 246326ef06412631c989eda2d776e62fc04eb8ef
                            lstSequenz.RemoveAt(i);
                            oSequenzeditor.FillGridSequenz();
                        }
                    }
                }
            }
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            NewDBDialog.Filter = "PharmMS (*.pharms)|*.pharms";
            NewDBDialog.FilterIndex = 2;
            NewDBDialog.RestoreDirectory = true;

            if (NewDBDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = NewDBDialog.OpenFile()) != null)
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        sDBName = Path.GetFileNameWithoutExtension(NewDBDialog.FileName);
                        sw.WriteLine(sDBName);
                        sDBPath = NewDBDialog.FileName;
                    }
                    stream.Close();
                }

                lstSequenz = new List<Sequenz>();
                bDBIsOpen = true;
                ImportStripMenuItem2.Enabled = true;
                speichernToolStripMenuItem.Enabled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Key;
            AblaufListe.Items.Clear();
            foreach (Sequenz oSequenz in lstSequenz)
            {
                for (int i = 0; i < SequenzenGrid.RowCount - 1; i++)
                {
                    Key = Convert.ToInt32(SequenzenGrid.Rows[i].Cells[3].Value.ToString());
                    if (Key == oSequenz.ObjectKey)
                    {
                        oSequenz.sName = SequenzenGrid.Rows[i].Cells[0].Value.ToString();
                        if (SequenzenGrid.Rows[i].Cells[1].Value.ToString() == "") oSequenz.iSpeicherplatz = -999;
                        else oSequenz.iSpeicherplatz = Convert.ToInt32(SequenzenGrid.Rows[i].Cells[1].Value.ToString()); //bei Übertragen Click wird der Speicherplatz auch nochmal gespeichert
                        break;
                    }
                }
                AblaufListe.Items.Add(oSequenz.sName);

                MasterGrid.RowValidating -= MasterGrid_RowValidating;                
                oSequenzeditor.FillGridMaster();
               MasterGrid.RowValidating += MasterGrid_RowValidating;
            }
        }

        private void btnUebertragen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SequenzenGrid.Rows.Count - 1; i++)
            {
                foreach (Sequenz oSequenz in lstSequenz)
                {
                    if (Convert.ToInt32(SequenzenGrid.Rows[i].Cells[3].Value) == oSequenz.ObjectKey)
                        oSequenz.iSpeicherplatz = (SequenzenGrid.Rows[i].Cells[1].Value.ToString() == "") ? -999 : Convert.ToInt32(SequenzenGrid.Rows[i].Cells[1].Value);
                }
            }

            /* ablauf = "";
             //neues übertragen Ereignis 
             foreach (Sequenz oSequenz in lstSequenz)
             {
                 if (SequenzenGrid.Rows[e.RowIndex].Cells[0].Value.ToString() == oSequenz.sName)
                 {
                     foreach (string line in oSequenz.stlSequenz)
                     {
                         if (line == "") continue;
                         ablauf = ablauf + ";" + line;


                     }
                     //Comschnitstelle.COMSender("Y" + oSequenz.iSpeicherplatz.ToString() + ablauf);
                     Console.WriteLine("Incoming Data:" + "Y" + oSequenz.iSpeicherplatz.ToString() + ablauf);
                 }
             }*/
        }
     
        public bool Messungen_Tabelle(int MessungNR, string Bezeichnung)
        {
            if (this.InvokeRequired)
            {

                return (bool)this.Invoke((Func<int, string,bool>)Messungen_Tabelle,MessungNR, Bezeichnung);

            }
            DataGridViewRow row = (DataGridViewRow)LiveGrid.Rows[0].Clone();
            row.Cells[0].Value = MessungNR;
            row.Cells[1].Value = Bezeichnung;

            LiveGrid.Rows.Add(row);
            return true;


        }


        public bool Live_Chart_add(int x, int Sen1 ,int Sen2, bool clear )
        {
            if (this.InvokeRequired)
            {

                return (bool)this.Invoke((Func<int, int,int, bool, bool>)Live_Chart_add, x , Sen1, Sen2 ,clear);

            }
            
            if (clear == true)
            {
                foreach (var series in LiveChart.Series)
                {
                    series.Points.Clear();
                }
               

            }
                LiveChart.Series[0].Points.AddXY(x, Sen1);
                LiveChart.Series[1].Points.AddXY(x, Sen2);
                LiveChart.Update();

            return true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LiveChart Ausgabe = new LiveChart();

            //Ausgabe zu Graphen
          
            Random z = new Random();
            for (int r = 0; r < 100; r++)
            {
                int x = z.Next(100);
                string s1 = x.ToString();
                x = z.Next(100);
                string s2 = x.ToString();

                Ausgabe.erfassen(s1, s2, this, false,true);
            }
            System.Threading.Thread.Sleep(5000);
            Ausgabe.erfassen("0", "0", this, true,true);

        }


        private void LiveGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LiveChart Ausgabe = new LiveChart();
            
            int selectedrowindex = LiveGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = LiveGrid.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Index.ToString());
            Ausgabe.erfassen(a, "0", this, true,false);
        }





        public void MasterGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            MasterGrid.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex == 0) ? 1 : Convert.ToInt32(MasterGrid.Rows[e.RowIndex - 1].Cells[0].Value) + 1;

            foreach (Sequenz oSequenz in lstSequenz)
            {
                if (oSequenz.iSpeicherplatz == Convert.ToInt32(MasterGrid.Rows[e.RowIndex].Cells[1].Value))
                    MasterGrid.Rows[e.RowIndex].Cells[2].Value = oSequenz.sName;
            }
            lstMaster.Add(Convert.ToInt32(MasterGrid.Rows[e.RowIndex].Cells[1].Value));
        }

        private void MasterGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            if (e.Exception != null)
            {
                MessageBox.Show("Masterablauf inkonsistent, der Masterablauf wird verworfen!");
                lstMaster.Clear();
                oSequenzeditor.FillGridMaster();
            }
        }
    }
}