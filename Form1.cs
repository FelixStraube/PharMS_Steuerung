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
    {
        static COM Comschnitstelle;
        string ablauf;
        public bool Connection;
        //public string Name;
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
        public List<string> stlLog = new List<string>();
        bool bDBIsOpen = false;
        bool bDBIsOpening = false;
        string sDBPath;
        string sDBName;
        public int maxObjectKey;
        public List<int> lstMaster = new List<int>();
        static bool Live_Cahrtausgabe = true;
        private int iSpeicherplatzForMNItem = -999;
        string AblaufListeVorAuswahl = "";


        public Form1()
        {
            InitializeComponent();
            
        }


        /*  private void Uebertragen_Click(object sender, EventArgs e)
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

          }*/

        private void Connect_Click(object sender, EventArgs e)
        {
            Comschnitstelle = new COM(this);
            panel1.BackColor = System.Drawing.Color.Green;
            Connection = true;
            tmCheckCOM.Enabled = true;

            if (Comschnitstelle.bereit)
            {
                btnElektrodenTest.Enabled = true;
                btnLeitungDes.Enabled = true;
                btnReg.Enabled = true;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            Comschnitstelle.COMDisconnect();
            panel1.BackColor = System.Drawing.Color.Red;
            Connection = false;
            btnElektrodenTest.Enabled = false;
            btnLeitungDes.Enabled = false;
            btnReg.Enabled = false;
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
            row.Cells[2].Value = Convert.ToDouble(Daten);
            row.Cells[3].Value = Convert.ToDouble(Daten2);
            DatenerfassungTab.Rows.Add(row);
            return true;
        }


        private void NOTSTOPP_Click(object sender, EventArgs e)
        {
            change_progressBar(-1, 0, progressBar1);
            Abbruch = true;
            Comschnitstelle.NotStop();
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
            if (lstMaster.Count == 0) return;

            Thread threadAblaufStart = new Thread(new ThreadStart(Comschnitstelle.Execute_Ablauf));
            stlLog.Add("Start threadAblaufStart" + "    " + System.DateTime.Now.ToString());
            threadAblaufStart.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!bDBIsOpen)
            {
                mnItemImport.Enabled = false;
                mnItemSpeichern.Enabled = false;
                mnItemSpeichernUnter.Enabled = false;
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

            tabControl1.Visible = false;


            /*  List<String> stlTest = new List<string>();
              CfgFile oCfgFile = new CfgFile("C:\\Users\\Alexander\\Desktop\\blubb\\Temp\\Daten Vom 1.4.2014.txt");
              stlTest = oCfgFile.Ausgabe();
              Datenerfassen test = new Datenerfassen("", this);
              foreach (string line in stlTest)
              {
                  test.BuildSource(line);
              }

              //chtMessung.Series[1].XValueMember = "Time";
              //chtMessung.Series[1].YValueMembers = "Sensor2";
           
              chtMessung.Series[0].XValueMember = "Time";
              chtMessung.Series[0].YValueMembers = "Sensor1";
              chtMessung.DataSource = test.TableMeasurements;
              chtMessung.DataBind();*/


        }

        private void Console_Senden_Click(object sender, EventArgs e)
        {
            Abbruch = false;
            Comschnitstelle.SendToCOM(Console_Eingabe.Text, true);
            Funktionen.Consolen_LOG Ausgabe = new Funktionen.Consolen_LOG(Console_Eingabe.Text, this);
        }

        private void Man_Messung_Click(object sender, EventArgs e)
        {
            Comschnitstelle.SendToCOM("p1,1", true);
            System.Threading.Thread.Sleep(500);
            Comschnitstelle.SendToCOM("U" + numericZellspannung.Value, true);
            int n = Convert.ToInt32(numeric_Intervall.Value);
            ende = Convert.ToInt32(numeric_Messdauer.Value);
            ende = ende * 60 / n;

            if (i == 1) Zeitsteuerung.Tick += new EventHandler(TimerEventProcessor);
            i = i + 1;
            alarmCounter = 1;
            Zeitsteuerung.Interval = n * 1000;
            Zeitsteuerung.Start();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {

            Zeitsteuerung.Stop();
            // Displays a message box asking whether to continue running the timer.

            if (alarmCounter <= ende)
            {
                Console.WriteLine("teste" + alarmCounter + ":" + ende);
                // Restarts the timer and increments the counter.
                Comschnitstelle.SendToCOM("M", true);
                alarmCounter += 1;
                Zeitsteuerung.Enabled = true;
                DatenerfassungTab.Refresh();
                DatenerfassungTab.PerformLayout();
            }
            else
            {
                //Datenerfassen test = new Datenerfassen("---------,---------", Comschnitstelle.tempForm);
                // Stops the timer.
                DatenerfassungTab.Refresh();
                DatenerfassungTab.PerformLayout();
                Exporting Save = new Exporting(DatenerfassungTab, Application.StartupPath+"Messdaten.txt");
                exitFlag = true;
            }
        }

        private void Messung_Stopp_Click(object sender, EventArgs e)
        {
            Comschnitstelle.SendToCOM("U0", true);
            System.Threading.Thread.Sleep(500);
            Comschnitstelle.SendToCOM("p1,0", true);
            ende = 0;
            SchleifenStopp = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAktiveMessung.Checked == true) { rbManuelleMessung.Checked = false; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManuelleMessung.Checked == true) { rbAktiveMessung.Checked = false; }
        }

        private void Initialisierung_Click(object sender, EventArgs e)
        {
            Comschnitstelle.SendToCOM("X01", true);
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
                mnItemImport.Enabled = true;
                mnItemSpeichern.Enabled = true;
                mnItemSpeichernUnter.Enabled = true;
                oSequenzeditor.FillGridSequenz();
                oSequenzeditor.FillGridMaster();
                bDBIsOpening = false;
                tabControl1.Visible = true;
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
                int i = e.RowIndex;
                lstSequenz.RemoveAt(i);

                oSequenzeditor.FillGridSequenz();
            }

        }
        private void SequenzenGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                m.MenuItems.Add(new MenuItem("Editieren"));
                m.MenuItems[0].Click += mnItemEditieren_Click;

                int icurrentMouseOverRow = SequenzenGrid.HitTest(e.X, e.Y).RowIndex;

                if (icurrentMouseOverRow >= 0)
                {
                    AblaufListeVorAuswahl = SequenzenGrid.Rows[icurrentMouseOverRow].Cells[0].Value.ToString();
                    if (SequenzenGrid.Rows[icurrentMouseOverRow].Cells[1].Value != null)
                        if (SequenzenGrid.Rows[icurrentMouseOverRow].Cells[1].Value.ToString() != "" && SequenzenGrid.Rows[icurrentMouseOverRow].Cells[1].Value.ToString() != "       ")
                        {
                            m.MenuItems.Add(new MenuItem("Starten"));
                            m.MenuItems[1].Click += mnItemStarten_Click;
                            iSpeicherplatzForMNItem = Convert.ToInt32(SequenzenGrid.Rows[icurrentMouseOverRow].Cells[1].Value.ToString());
                        }
                    m.Show(SequenzenGrid, new Point(e.X, e.Y));
                }

            }
        }


        void mnItemStarten_Click(object sender, EventArgs e)
        {
            Comschnitstelle.SendToCOM("X" + iSpeicherplatzForMNItem.ToString(), true);
        }
        void mnItemEditieren_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSequenzedit;
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
                mnItemImport.Enabled = true;
                mnItemSpeichern.Enabled = true;
            }
            tabControl1.Visible = true;
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
                        if (SequenzenGrid.Rows[i].Cells[1].Value.ToString() == "" || SequenzenGrid.Rows[i].Cells[1].Value.ToString() == "       ") oSequenz.iSpeicherplatz = -999;
                        else oSequenz.iSpeicherplatz = Convert.ToInt32(SequenzenGrid.Rows[i].Cells[1].Value.ToString()); //bei Übertragen Click wird der Speicherplatz auch nochmal gespeichert
                        break;
                    }
                }
                AblaufListe.Items.Add(oSequenz.sName);
            }

            AblaufListe.SelectedItem = AblaufListeVorAuswahl;
            MasterGrid.RowValidating -= MasterGrid_RowValidating;
            oSequenzeditor.FillGridSequenzEdit();
            oSequenzeditor.FillGridMaster();
            MasterGrid.RowValidating += MasterGrid_RowValidating;

           /* if (Comschnitstelle != null)
            {               
                if (rbAktiveMessung.Checked)
                    DatenerfassungTab.DataSource = Comschnitstelle.Ausgabe_automatisch.TableMeasurements;
                else
                    DatenerfassungTab.DataSource = Comschnitstelle.Ausgabe_manuel.TableMeasurements;

                DatenerfassungTab.Refresh();
                DatenerfassungTab.PerformLayout(); 
                
            }*/
            // Kein Treatsicher Zugriff wenn scroll_Bar erscheint :-= Fehler Alternativ => DatenerfassungTab_Hinzu im Com 
        }

        private void btnUebertragen_Click(object sender, EventArgs e)
        {
            List<String> lstCommands = new List<string>();
            for (int i = 0; i < SequenzenGrid.Rows.Count - 1; i++)
            {
                foreach (Sequenz oSequenz in lstSequenz)
                {
                    if (Convert.ToInt32(SequenzenGrid.Rows[i].Cells[3].Value) == oSequenz.ObjectKey)
                        oSequenz.iSpeicherplatz = (SequenzenGrid.Rows[i].Cells[1].Value.ToString() == "" || SequenzenGrid.Rows[i].Cells[1].Value.ToString() == "       ") ? -999 : Convert.ToInt32(SequenzenGrid.Rows[i].Cells[1].Value);
                }
            }

            //neues übertragen Ereignis 
            foreach (Sequenz oSequenz in lstSequenz)
            {
                ablauf = "";
                foreach (string line in oSequenz.stlSequenz)
                {
                    if (line == "") continue;
                    ablauf = ablauf + ";" + line;
                }
                if (oSequenz.iSpeicherplatz.ToString() != "-999")
                {
                    lstCommands.Add("Y" + oSequenz.iSpeicherplatz.ToString() + ablauf);
                    Console.WriteLine("Incoming Data gesendet:" + "Y" + oSequenz.iSpeicherplatz.ToString() + ablauf);
                    stlLog.Add("Incoming Data gesendet:" + "Y" + oSequenz.iSpeicherplatz.ToString() + ablauf + "    " + System.DateTime.Now.ToString());
                }
            }
            COM.Sequenzen_uebertragen_aktiv = true;
            BackgroundWorker BackgroundWorkerSendSequenz = new BackgroundWorker();
            
            stlLog.Add("Start BackgroundWorkerSendSequenz" + "    " + System.DateTime.Now.ToString());
            BackgroundWorkerSendSequenz.RunWorkerCompleted += BackgroundWorkerSendSequenz_RunWorkerCompleted;
            BackgroundWorkerSendSequenz.DoWork += BackgroundWorkerCommands_DoWork;
            BackgroundWorkerSendSequenz.RunWorkerAsync(new HelpClass(1, lstCommands.ToArray()));
            BackgroundWorkerSendSequenz.Dispose();
            
        }

        public bool Messungen_Tabelle(int MessungNR, string Bezeichnung)
        {
            if (this.InvokeRequired)
            {
                return (bool)this.Invoke((Func<int, string, bool>)Messungen_Tabelle, MessungNR, Bezeichnung);
            }
            DataGridViewRow row = (DataGridViewRow)LiveGrid.Rows[0].Clone();
            row.Cells[0].Value = MessungNR;
            row.Cells[1].Value = Bezeichnung;

            LiveGrid.Rows.Add(row);
            return true;
        }


        public bool Live_Chart_add(int x, decimal Sen1, decimal Sen2, bool clear)
        {
            if (this.InvokeRequired)
            {
                return (bool)this.Invoke((Func<int, decimal, decimal, bool, bool>)Live_Chart_add, x, Sen1, Sen2, clear);
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

        private void LiveChart_klick(object sender, EventArgs e)
        {
            LiveChart Ausgabe = new LiveChart();
            Live_Cahrtausgabe = true;
            Live_Chart_anzeigen.Visible = false;
            Live_Chart_add(0, 0, 0, true);

            /*Ausgabe.erfassen("0", "0", this, true, true);



            //Ausgabe zu Graphen

            Random z = new Random();
            for (int r = 0; r < 100; r++)
            {
                int x = z.Next(100);
                string s1 = x.ToString();
                x = z.Next(100);
                string s2 = x.ToString();

                Ausgabe.erfassen(s1, s2, this, false, true);
            }
            System.Threading.Thread.Sleep(5000);*/


        }


        private void LiveGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LiveChart Ausgabe = new LiveChart();
            Live_Cahrtausgabe = false;
            Live_Chart_anzeigen.Visible = true;
            int selectedrowindex = LiveGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = LiveGrid.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Index.ToString());
            // Ausgabe.erfassen(a, "0", this, true,false);

            Ausgabe.ausgabeSpeicher(a, this);

        }

        public void MasterGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            bool bMatch = false;
            foreach (Sequenz oSequenz in lstSequenz)
            {
                if (oSequenz.iSpeicherplatz == Convert.ToInt32(MasterGrid.Rows[e.RowIndex].Cells[1].Value))
                {
                    MasterGrid.Rows[e.RowIndex].Cells[2].Value = oSequenz.sName;
                    bMatch = true;
                }
                else
                    if (oSequenz.sName == Convert.ToString(MasterGrid.Rows[e.RowIndex].Cells[2].Value))
                    {
                        MasterGrid.Rows[e.RowIndex].Cells[1].Value = oSequenz.iSpeicherplatz.ToString();
                        bMatch = true;
                    }
            }

            if (e.RowIndex >= lstMaster.Count && bMatch)
                lstMaster.Add(Convert.ToInt32(MasterGrid.Rows[e.RowIndex].Cells[1].Value));

            if (bMatch) MasterGrid.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex == 0) ? 1 : Convert.ToInt32(MasterGrid.Rows[e.RowIndex - 1].Cells[0].Value) + 1;

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

        private void SequenzenGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {   int Sequenzahler = 0;
            if (e.ColumnIndex == 1)
               
                
                for (int i = 0; i < SequenzenGrid.Rows.Count - 1; i++)
                {
                    foreach (Sequenz oSequenz in lstSequenz)
                    {
                        if (Convert.ToInt32(SequenzenGrid.Rows[i].Cells[3].Value) == oSequenz.ObjectKey)
                            oSequenz.iSpeicherplatz = (SequenzenGrid.Rows[i].Cells[1].Value.ToString() == "" || SequenzenGrid.Rows[i].Cells[1].Value.ToString() == "       ") ? -999 : Convert.ToInt32(SequenzenGrid.Rows[i].Cells[1].Value);
                    }
                }
               
            
            foreach (Sequenz oSequenz in lstSequenz)
            {
                Sequenzahler=(sender as DataGridView).CurrentCell.ColumnIndex;
                string test = oSequenz.ObjectKey.ToString();


                if (oSequenz.iSpeicherplatz.ToString() == (sender as DataGridView).CurrentCell.EditedFormattedValue.ToString() && (sender as DataGridView).CurrentCell.EditedFormattedValue.ToString() != "       ")
                    {
                        MessageBox.Show("Speicherplatz bereits vergeben!");
                        e.Cancel = true;
                    }

                if (oSequenz.ObjectKey.ToString() == Sequenzahler.ToString() && (sender as DataGridView).CurrentCell.EditedFormattedValue.ToString() == "       ") 
                            {
                                lstSequenz[Sequenzahler].iSpeicherplatz = -999;
                            }   
            
            }
        }


        private void MasterGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            lstMaster.RemoveAt((sender as DataGridView).NewRowIndex);
            oSequenzeditor.FillGridMaster();
        }

        private void tmCheckCOM_Tick(object sender, EventArgs e)
        {

            /* bool bNeedNewLine = true;

             if (Comschnitstelle == null)
             {
                 stlLog.Add("Portstatus: Comschnitstelle existiert nicht");
                 tmCheckCOM.Enabled = false;
             }


             if (Comschnitstelle.port.IsOpen)
             {
                 if (bNeedNewLine) stlLog.Add("Portstatus: " + Comschnitstelle.port.IsOpen.ToString() + "    " + System.DateTime.Now.ToString());
                 bNeedNewLine = false;

             }
             else
             {
                 bNeedNewLine = true;
                 stlLog.Add("Portstatus: " + Comschnitstelle.port.IsOpen.ToString() + "    " + System.DateTime.Now.ToString());
                 stlLog.Add("Versuch der Reaktivierung");
                 Comschnitstelle.port.Close();
                 Comschnitstelle.port.Open();
             }*/
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllLines("LogCOM.txt", stlLog);
        }

        private void rbTemperierungEin_CheckedChanged(object sender, EventArgs e)
        {
            txtboxTemperatur.ReadOnly = true;
            if (rbTemperierungEin.Checked)
            {
                txtboxTemperatur.ReadOnly = false;
                string Temp = txtboxTemperatur.Text.ToString();
                if (Temp.IndexOf(",") != null)
                {
                    Temp = Temp.Replace(",", ".");

                };
                Comschnitstelle.SendToCOM("T" + Temp, true);
                System.Threading.Thread.Sleep(500);
                Comschnitstelle.SendToCOM("o1", true);
                
            }


        }

        private void btnNeueMessung_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Möchten Sie die bestehende Messdaten sichern?", "Messdaten", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                button2.PerformClick();
            }
            else
            {
                DatenerfassungTab.Rows.Clear();
            }
        }

        private void rbAktiveMessung_CheckedChanged(object sender, EventArgs e)
        {
            if (!Comschnitstelle.bereit) MessageBox.Show("Manuelle Messung im laufenden Gerätebetrieb nicht möglich!");
            else
            {
                if (rbAktiveMessung.Checked)
                {
                    lbMessmethode.Text = "aktive Messung";
                    btnNeueMessung.Enabled = false;
                }
                if (rbManuelleMessung.Checked)
                {
                    lbMessmethode.Text = "manuelle Messung";
                    btnNeueMessung.Enabled = true;
                }
            }
        }

        private void mnItemSpeichernUnter_Click(object sender, EventArgs e)
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
                        lstSequenz[0].sDBName = sDBName;
                        sw.WriteLine(sDBName);
                        sDBPath = NewDBDialog.FileName;
                    }
                    stream.Close();
                    SaveDatabase();
                }
            }
        }

        private void btnElektrodenTest_Click(object sender, EventArgs e)
        {
            if (Comschnitstelle.bereit)
            {
                Comschnitstelle.SendToCOM(Sequenz.ElektrodenTest(), true);
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.ElektrodenTest());
                stlLog.Add("Incoming Data gesendet:" + Sequenz.ElektrodenTest() + "    " + System.DateTime.Now.ToString());
                MessageBox.Show("Zuleitung 7 zu Ventil 2 in Testlösung führen !");
                MessageBox.Show("Messdauer 1 min mit 5s taktung !");
                numeric_Intervall.Value = 5;
                numeric_Messdauer.Value = 10;                
                Comschnitstelle.SendToCOM("X20", true);
                Console.WriteLine("X20");
                stlLog.Add("X20");
                tabControl1.SelectedTab = tabPage2;
            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }

        private void btnLeitungDes_Click(object sender, EventArgs e)
        {
            if (Comschnitstelle.bereit)
            {
                tabControl1.SelectedTab = tabPage1;
                Comschnitstelle.SendToCOM(Sequenz.LeitungenSpuelen(true), true);
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(true));
                stlLog.Add("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(true) + "    " + System.DateTime.Now.ToString()); 
                MessageBox.Show("Schritt 1: Desinfektion \n 1. Inkubationsgefäße gegen Blindgefäße austauschen! \n 2. Zuleitungen 1, 2, 3, 6, 7 zu Ventil 2 in separates Abfallgefäß führen! \n 3. Puffergefäß gegen Desinfektionsmittelgefäß austauschen!");
                System.Threading.Thread.Sleep(2000);
                Comschnitstelle.SendToCOM(Sequenz.LeitungenSpuelen(false), true);
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(false));
                stlLog.Add("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(false) + "    " + System.DateTime.Now.ToString());
                

                BackgroundWorker BackgroundWorkerDesinfect = new BackgroundWorker();
                stlLog.Add("Start BackgroundWorkerDesinfect" + "    " + System.DateTime.Now.ToString());
                BackgroundWorkerDesinfect.RunWorkerCompleted += BackgroundWorkerDesinfect_RunWorkerCompleted;
                BackgroundWorkerDesinfect.DoWork += BackgroundWorkerCommands_DoWork;
                BackgroundWorkerDesinfect.RunWorkerAsync(new HelpClass((int)numDesinfektion.Value, "X18", "X19", "W0,01"));
                BackgroundWorkerDesinfect.Dispose();
            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (Comschnitstelle.bereit)
            {
                Comschnitstelle.SendToCOM(Sequenz.ElektrodenReg(), true);
                BackgroundWorker BackgroundWorkerReg = new BackgroundWorker();
                stlLog.Add("Start BackgroundWorkerReg" + "    " + System.DateTime.Now.ToString());
                BackgroundWorkerReg.DoWork += BackgroundWorkerCommands_DoWork;
                BackgroundWorkerReg.RunWorkerCompleted += BackgroundWorkerReg_RunWorkerCompleted;
                BackgroundWorkerReg.RunWorkerAsync(new HelpClass(1, "X20","W0,01"));
                BackgroundWorkerReg.Dispose();
                tabControl1.SelectedTab = tabPage1;
            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }

        void BackgroundWorkerReg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stlLog.Add("Completed BackgroundWorkerReg" + "    " + System.DateTime.Now.ToString());
            MessageBox.Show("Elektroden wurden regeneriert!");
        }
        void BackgroundWorkerSendSequenz_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            COM.Sequenzen_uebertragen_aktiv = false;
            MessageBox.Show("Sequenzen wurden an das Gerät übertragen!");
            stlLog.Add("Sequenzen wurden an das Gerät übertragen!" + "    " + System.DateTime.Now.ToString());
            
        }
        void BackgroundWorkerDesinfect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stlLog.Add("Completed BackgroundWorkerDesinfect" + "    " + System.DateTime.Now.ToString());
            MessageBox.Show("Schritt 2: Spülen \n Desinfektionsmittelgefäß gegen Puffergefäß austauschen!");

            BackgroundWorker BackgroundWorkerFlush = new BackgroundWorker();
            stlLog.Add("Start BackgroundWorkerFlush" + "    " + System.DateTime.Now.ToString());
            BackgroundWorkerFlush.RunWorkerCompleted += BackgroundWorkerFlush_RunWorkerCompleted;
            BackgroundWorkerFlush.DoWork += BackgroundWorkerCommands_DoWork;
            BackgroundWorkerFlush.RunWorkerAsync(new HelpClass((int)numSpuelen.Value, "X18", "X19", "W0,01"));
            BackgroundWorkerFlush.Dispose(); 
        }
        void BackgroundWorkerFlush_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stlLog.Add("Completed BackgroundWorkerFlush" + "    " + System.DateTime.Now.ToString());
            MessageBox.Show("System desinfiziert und gespült.\n 1. Blindgefäße gegen Inkubationsgefäße austauschen! \n 2. Zuleitungen zu Ventil 2 in die jeweiligen Vorratsgefäße führen!");
        }
        private void BackgroundWorkerCommands_DoWork(object sender, DoWorkEventArgs e)
        {    
            Comschnitstelle.Execute_Commands(((HelpClass)e.Argument).iRepeat, ((HelpClass)e.Argument).arrCommands);
        }

        private void rbPumpeMesszelleAus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPumpeMesszelleAus.Checked)
            {
                rbPumpeMesszelleEin.Checked = false;
                Comschnitstelle.SendToCOM("p1,0", true);
            }
        }

        private void rbPumpeMesszelleEin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPumpeMesszelleEin.Checked)
            {
                rbPumpeMesszelleAus.Checked = false;
                Comschnitstelle.SendToCOM("p1,1", true);
            }
        }

        private void rbPumpeAbfallEin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPumpeAbfallEin.Checked)
            {
                rbPumpeAbfallAus.Checked = false;
                Comschnitstelle.SendToCOM("p2,1", true);
            }
        }

        private void rbPumpeAbfallAus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPumpeAbfallAus.Checked)
            {
                rbPumpeAbfallEin.Checked = false;
                Comschnitstelle.SendToCOM("p2,0", true);
            }
        }

        private void rbTemperierungAus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTemperierungAus.Checked)
            {
                rbTemperierungEin.Checked = false;
                Comschnitstelle.SendToCOM("o0", true);
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ChartForm _Chart = new ChartForm(this);
            _Chart.Show();
        }

    }

    public class HelpClass
    {
        public int iRepeat;
        public string[] arrCommands;

        public HelpClass(int Repeat, params string[] Commands)
        {
            iRepeat = Repeat;
            arrCommands = Commands;

        }
    }
}