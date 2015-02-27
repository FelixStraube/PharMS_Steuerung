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
using System.Reflection;


namespace PharMS_Steuerung
{

    public partial class Form1 : Form
    {

        string AblaufListeVorAuswahl;



        public int Prozessstand;
        public static int ende;
        public bool SchleifenStopp = false;
        private LiveChartForm _LiveChart;
        //    static System.Windows.Forms.Timer Zeitsteuerung = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;
        public Sequenzeditor oSequenzeditor;

        public DataGridView Temp = new DataGridView();
        public int maxObjectKey;

        static bool Live_Cahrtausgabe = true;
        private int iSpeicherplatzForMNItem = -999;

        private Communicator oCommunicator;
        public SQLMain DBMain;


        public Form1()
        {
            InitializeComponent();

        }
        private void Connect_Click(object sender, EventArgs e)
        {

            if (oCommunicator.ConnectToDevice())
            {
                panel1.BackColor = System.Drawing.Color.Green;
                btnElektrodenTest.Enabled = true;
                btnLeitungDes.Enabled = true;
                btnReg.Enabled = true;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {

            if (!oCommunicator.DisconnectDevice())
            {
                panel1.BackColor = System.Drawing.Color.Red;

                btnElektrodenTest.Enabled = false;
                btnLeitungDes.Enabled = false;
                btnReg.Enabled = false;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Documents (*.csv)|*.csv";
            sfd.FileName = "export.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                DataView dvMesswerte = new DataView(DBMain.dsPharms.Tables["Messwerte"]);

                //Temp.DataSource = dvMesswerte;
                DatenerfassungTab.DataSource = dvMesswerte;

                CSV_Export.toCSV(DatenerfassungTab, sfd.FileName, DBMain);
            }

            oSequenzeditor.FillGridMeasurements();
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
            oCommunicator.Stopp();
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
            if (oCommunicator.IsWithMakro)
                oCommunicator.StartMasterAblaufMitMakro(Convert.ToInt32(numericUpDown1.Value));
            else
                oCommunicator.StartMasterAblaufBefehlsweise(Convert.ToInt32(numericUpDown1.Value));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mnItemSpeichern.Enabled = false;
            mnItemSpeichernUnter.Enabled = false;

            oSequenzeditor = new Sequenzeditor(this);
            //this.Width = 580;
            //this.Height = 680;
            tabControl1.Visible = false;

        }

        private void Console_Senden_Click(object sender, EventArgs e)
        {
            oCommunicator.SendFromConsole(Console_Eingabe.Text);
        }

        private void Man_Messung_Click(object sender, EventArgs e)
        {
            oCommunicator.StartManuelleMessung((int)numericZellspannung.Value);
        }
        /*
                private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
                {

                    Zeitsteuerung.Stop();
                    // Displays a message box asking whether to continue running the timer.

                    if (alarmCounter <= ende && ende != 0)
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
                        Exporting Save = new Exporting(DatenerfassungTab, Application.StartupPath + "Messdaten.txt");
                        exitFlag = true;
                    }
                } */

        private void Messung_Stopp_Click(object sender, EventArgs e)
        {
            oCommunicator.StoppManuelleMessung();
        }


        private void Initialisierung_Click(object sender, EventArgs e)
        {
            
            oCommunicator.SendToCOM("X01");           
        }

        private void AblaufListe_SelectedValueChanged(object sender, EventArgs e)
        {
            oSequenzeditor.FillGridSequenzEdit();
            string value = "";
            foreach (DataGridViewRow Row in SequenzeditorGrid.Rows)
            {
                if (Row.Cells["Befehl"].Value != null)
                {
                    Sequenzeditor.dictSequenzBefehle.TryGetValue(Row.Cells["Befehl"].Value.ToString(), out value);
                    Row.Cells["Erklärung"].Value = value;
                }
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
                    if (SequenzenGrid.Rows[icurrentMouseOverRow].Cells["Speicherplatz"].Value != null)
                        if (SequenzenGrid.Rows[icurrentMouseOverRow].Cells["Speicherplatz"].Value.ToString() != "" && SequenzenGrid.Rows[icurrentMouseOverRow].Cells["Speicherplatz"].Value.ToString() != "       ")
                        {
                            m.MenuItems.Add(new MenuItem("Starten"));
                            m.MenuItems[1].Click += mnItemStarten_Click;
                            iSpeicherplatzForMNItem = Convert.ToInt32(SequenzenGrid.Rows[icurrentMouseOverRow].Cells["Speicherplatz"].Value.ToString());
                        }
                    m.Show(SequenzenGrid, new Point(e.X, e.Y));
                }

            }
        }


        void mnItemStarten_Click(object sender, EventArgs e)
        {
            oCommunicator.SendToCOM("X" + iSpeicherplatzForMNItem.ToString());
        }
        void mnItemEditieren_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSequenzedit;
            AblaufListe.SelectedValue = AblaufListeVorAuswahl;
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewDBDialog.Filter = "DB3 (*.db3)|*.db3";
            NewDBDialog.FilterIndex = 2;
            NewDBDialog.RestoreDirectory = true;

            if (NewDBDialog.ShowDialog() == DialogResult.OK)
            {
                DBMain = new SQLMain(NewDBDialog.FileName);

                oSequenzeditor.LoadGridSequenz();

                oSequenzeditor.FillGridMaster();

                oSequenzeditor.FillGridMeasurements();
                oSequenzeditor.FillGridMesszyklus();

                AblaufListe.DisplayMember = "Name";
                AblaufListe.ValueMember = "ID";
                AblaufListe.DataSource = DBMain.dsPharms.Tables["Sequenzen"];

                mnItemSpeichern.Enabled = true;
                mnItemSpeichernUnter.Enabled = true;
                tabControl1.Visible = true;
            }

        }


        private void mnItemSpeichernUnter_Click(object sender, EventArgs e)
        {
            NewDBDialog.Filter = "DB3 (*.db3)|*.db3";
            NewDBDialog.FilterIndex = 2;
            NewDBDialog.RestoreDirectory = true;

            if (NewDBDialog.ShowDialog() == DialogResult.OK)
            {
                SQLMain DBMainCopy = new SQLMain(NewDBDialog.FileName);


            }

        }

        private void datenbankÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDatabaseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DBMain = new SQLMain(openDatabaseDialog.FileName);
                oSequenzeditor.LoadGridSequenz();

                oSequenzeditor.FillGridMaster();

                oSequenzeditor.FillGridMeasurements();

                oSequenzeditor.FillGridMesszyklus();

                tabControl1.Visible = true;

                AblaufListe.DisplayMember = "Name";
                AblaufListe.ValueMember = "ID";
                AblaufListe.DataSource = DBMain.dsPharms.Tables["Sequenzen"];


                mnItemSpeichern.Enabled = true;
                mnItemSpeichernUnter.Enabled = true;

                Consolen_LOG ausg = new Funktionen.Consolen_LOG(this);
                oCommunicator = new Communicator(DBMain, ausg);
                oCommunicator.Messdauer = (int)numeric_Messdauer.Value;
                oCommunicator.Messintervall = (int)numeric_Intervall.Value;
                oCommunicator.Responsetime = (int)numericResponsetime.Value;

            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBMain.Save();
        }


        private void btnUebertragen_Click(object sender, EventArgs e)
        {
            oCommunicator.UebertragenMakros();
        }



        private void btnTemperierungEin(object sender, EventArgs e)
        {
            string Temp = txtboxTemperatur.Text.ToString();
            if (Temp.IndexOf(",") != null)
            {
                Temp = Temp.Replace(",", ".");

            };
            oCommunicator.SendToCOM("T" + Temp);
            System.Threading.Thread.Sleep(500);
            oCommunicator.SendToCOM("o1");
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

                for (int i = 0; i < DBMain.dsPharms.Tables["Messwerte"].Rows.Count; i++)
                {
                    DBMain.dsPharms.Tables["Messwerte"].Rows[i].Delete();
                }
                DBMain.SaveMeasurements();

            }
        }

        private void btnElektrodenTest_Click(object sender, EventArgs e)
        {
            oCommunicator.SendElektrodenTest();
        }

        private void btnLeitungDes_Click(object sender, EventArgs e)
        {

            oCommunicator.SendLeitungDesk((int)numDesinfektion.Value, (int)numSpuelen.Value);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            oCommunicator.SendReg();
        }

        private void btnPumpeMesszelleAus(object sender, EventArgs e)
        {
            oCommunicator.SendToCOM("p1,0");

        }

        private void btnPumpeMesszelleEin(object sender, EventArgs e)
        {

            oCommunicator.SendToCOM("p1,1");
      
        }

        private void btnPumpeAbfallEin(object sender, EventArgs e)
        {

            oCommunicator.SendToCOM("p2,1");
   
        }

        private void btnPumpeAbfallAus(object sender, EventArgs e)
        {

            oCommunicator.SendToCOM("p2,0");
   
        }

        private void btnTemperierungAus(object sender, EventArgs e)
        {

            oCommunicator.SendToCOM("o0");
        }


        private void btnChart_Click(object sender, EventArgs e)
        {
            int SelectedRow = MesszyklusGrid.CurrentCell.RowIndex;

            ChartForm _Chart = new ChartForm(this);
            _Chart.Show();
        }

        private void SequenzeditorGrid_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["S_ID"].Value = Convert.ToInt32(AblaufListe.SelectedValue);
            e.Row.Cells["Reihenfolge"].Value = SequenzeditorGrid.RowCount; ;
        }


        private void MasterGrid_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Reihenfolge"].Value = MasterGrid.RowCount;

        }

        private void MasterGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (MasterGrid.Rows[e.RowIndex].Cells["Name"].Value != null)
                MasterGrid.Rows[e.RowIndex].Cells["Name"].Value = "Dummy";

            if ((MasterGrid.Rows[e.RowIndex].Cells["Sequenz"] as DataGridViewComboBoxCell).Value.ToString() != "")
                MasterGrid.Rows[e.RowIndex].Cells["Speicherplatz"].Value = DBMain.GetSequenzMemoryByID(Convert.ToInt32((MasterGrid.Rows[e.RowIndex].Cells["Sequenz"] as DataGridViewComboBoxCell).Value));

        }

        private void SequenzeditorGrid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string value = "";
            if (SequenzeditorGrid.Columns["Befehl"] != null && SequenzeditorGrid.Columns["Erklärung"] != null)
            {
                Sequenzeditor.dictSequenzBefehle.TryGetValue(SequenzeditorGrid.Rows[e.RowIndex].Cells["Befehl"].Value.ToString(), out value);
                SequenzeditorGrid.Rows[e.RowIndex].Cells["Erklärung"].Value = value;
            }
        }



        private void MasterGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (e.Exception.Message == "Spalte 'S_ID' läßt nicht 'nulls' zu.")
                {
                    MasterGrid.Rows[e.RowIndex].Cells[1].Value = null;
                }
                else
                {
                    MessageBox.Show("Masterablauf inkonsistent, der Masterablauf wird verworfen!");
                    oSequenzeditor.FillGridMaster();
                }
            }

        }

        private void MesszyklusGrid_SelectionChanged(object sender, EventArgs e)
        {
            oSequenzeditor.FillGridMeasurements();
        }

        private void SequenzenGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DBMain.DeleteSequenzEditByID(Convert.ToInt32(e.Row.Cells["ID"].Value));
        }

        private void MesszyklusGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DBMain.DeleteMeasurementByID(Convert.ToInt32(e.Row.Cells["ID"].Value));
        }

        private void DatenerfassungTab_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Möchten Sie Ihre Änderungen speichern?", "Speichern", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { DBMain.Save(); }
            if (result == DialogResult.Cancel)
            { e.Cancel = true; }

            if (oCommunicator != null)
                oCommunicator.SaveLog();

        }

        private void btnLiveChart_Click(object sender, EventArgs e)
        {

            int SelectedRow = MesszyklusGrid.CurrentCell.RowIndex;

            _LiveChart = new LiveChartForm(this);
            _LiveChart.Show();
        }

        private void numeric_Intervall_ValueChanged(object sender, EventArgs e)
        {
            oCommunicator.Messintervall = (int)numeric_Intervall.Value;
        }

        private void numeric_Messdauer_ValueChanged(object sender, EventArgs e)
        {
            oCommunicator.Messdauer = (int)numeric_Messdauer.Value;
        }

        private void numericResponsetime_ValueChanged(object sender, EventArgs e)
        {
            oCommunicator.Responsetime = (int)numericResponsetime.Value;
        }


    }
}