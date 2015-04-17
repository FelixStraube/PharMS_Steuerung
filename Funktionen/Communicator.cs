using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.IO;
using System.Timers;
using System.Data;

namespace PharMS_Steuerung.Funktionen
{
    class Communicator
    {
        #region Variablen

        private List<string> lstMaster;
        private static COM oComschnitstelle;
        private int CountMasterIteration;
        private Consolen_LOG FormLog;
        private int CountSpulItereation;
        private string sExpectedStatus;
        private string sMakroEndeZeichen;
        private string sZyklus;
        private int iTickInterval, iTickAktuell;
        public System.Timers.Timer tmrResponsetimer;

        public System.Timers.Timer tmrMesswerteTimer;
        public System.Timers.Timer tmrAfterAllMesswerte;
        public System.Timers.Timer tmrCheckStatus;
        public bool bStopTimer = false;
        public bool bZyklusActive = false;
        public bool bIsManuelleMessung = false;
        public bool bIgnoreNewMeasurements = false;
        public bool Sequenzen_uebertragen_aktiv = false;
        public int ende;
        public int Messdauer, Messintervall, Responsetime;
        public bool IsWithMakro;
        public bool IsMasterThreadActiv;

        public SQLMain DBMain;
        public bool Abbruch; //Abruch der Kommunikation 
        public bool Connection; //eher nach COM auslagern 
        #endregion


        #region Grundlegendefunktionen
        public Communicator(SQLMain p_DBMain, Consolen_LOG p_FormLog)
        {
            DBMain = p_DBMain;
            FormLog = p_FormLog;

            CfgFile Config = new CfgFile("Config.ini");
            sMakroEndeZeichen = Config.getValue("Steuerzeichen", "MakroEnde", false);

            if (GlobalVar.IsTest)
            {
                oComschnitstelle = new COM(this);
                Connection = true;
                oComschnitstelle.bereit = true; //zum test ohne Gerät
            }

        }
        public void SaveLog()
        {

            File.WriteAllText("LogCOM-" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm") + ".txt", FormLog.GetLog());
            //File.WriteAllLines("LogCOM.txt", FormLog.GetLog());
        }

        public bool ConnectToDevice()
        {
            oComschnitstelle = new COM(this);
            Connection = true;
            return Connection;

        }
        public bool DisconnectDevice()
        {
            oComschnitstelle.COMDisconnect();
            Connection = false;
            return Connection;
        }

        public void Stopp()
        {
            Abbruch = true;
            oComschnitstelle.NotStop();
        }
        #endregion

        #region Masterablauffunktionen
        public void StartMasterAblaufMitMakro(int p_PCountMasterIteration)
        {
            var result = MessageBox.Show("Wurde die Messdauer entsprechend des Ablaufes angepasst?", "Messparameter unter Geräteparameter anpassen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstMaster = DBMain.GetMasterablauf();
                Abbruch = false;
                CountMasterIteration = p_PCountMasterIteration;
                if (lstMaster.Count == 0) return;

                Thread threadAblaufStart = new Thread(new ThreadStart(Execute_MakroAblauf));
                FormLog.AddLog("Start threadAblaufStart" + "    " + System.DateTime.Now.ToString());
                threadAblaufStart.Start();
            }

        }
        public void StartMasterAblaufBefehlsweise()
        {
            //  CountMasterIteration = p_PCountMasterIteration;

            Abbruch = false;

            BackgroundWorker BackgroundWorkerEinzelbefehle = new BackgroundWorker();
            FormLog.AddLog("Start BackgroundWorkerSendSequenz" + "    " + System.DateTime.Now.ToString());
            BackgroundWorkerEinzelbefehle.RunWorkerCompleted += BackgroundWorkerEinzelbefehle_RunWorkerCompleted;
            BackgroundWorkerEinzelbefehle.DoWork += BackgroundWorkerMasterEinzelbefehle_DoWork;
            BackgroundWorkerEinzelbefehle.RunWorkerAsync();
            IsMasterThreadActiv = true;
            BackgroundWorkerEinzelbefehle.Dispose();
        }

        public void StartSequenzfBefehlsweise(int ID)
        {
            //  CountMasterIteration = p_PCountMasterIteration;

            Abbruch = false;

            BackgroundWorker BackgroundWorkerEinzelbefehle = new BackgroundWorker();
            FormLog.AddLog("Start BackgroundWorkerSendSequenz" + "    " + System.DateTime.Now.ToString());
            BackgroundWorkerEinzelbefehle.RunWorkerCompleted += BackgroundWorkerEinzelbefehle_RunWorkerCompleted;
            BackgroundWorkerEinzelbefehle.DoWork += BackgroundWorkerEinzelbefehle_DoWork;
            BackgroundWorkerEinzelbefehle.RunWorkerAsync(ID);
            IsMasterThreadActiv = true;
            BackgroundWorkerEinzelbefehle.Dispose();

        }

        private void Execute_MakroAblauf()
        {
            for (int z = 0; z < CountMasterIteration; z++)
            {
                for (int i = 0; i < lstMaster.Count; i++) // warum hast du davor mit 1 angefangen und warum befindet sich die Methode überhaupt in der MainForm?
                {
                    Boolean Lauf = true;
                    do
                    {
                        if (Abbruch == true) return;
                        Lauf = oComschnitstelle.SendToCOM("X" + lstMaster[i], false);

                        FormLog.AddLog("Gesendet : " + lstMaster[i]);

                        if (Lauf == true) Console.WriteLine("Line: " + i + ";" + lstMaster.Count + ";" + "X" + lstMaster[i]);
                        if (Lauf == true) FormLog.AddLog("Line: " + i + ";" + lstMaster.Count + ";" + "X" + lstMaster[i]);
                        System.Threading.Thread.Sleep(1000);

                    } while (Lauf == false);
                }

            }
            FormLog.AddLog("Completed threadAblaufStart" + "    " + System.DateTime.Now.ToString());
        }
        #endregion

        #region Controller für Form
        public void SendElektrodenTest()
        {
            if (oComschnitstelle.bereit)
            {
                oComschnitstelle.SendToCOM(Sequenz.ElektrodenTest(), true);
                sExpectedStatus = "Z";
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.ElektrodenTest());
                FormLog.AddLog("Incoming Data gesendet:" + Sequenz.ElektrodenTest() + "    " + System.DateTime.Now.ToString());
                MessageBox.Show("Zuleitung 7 zu Ventil 2 in Testlösung führen !");//TODO evt abbrechen

                BackgroundWorker BackgroundWorkerTest = new BackgroundWorker();
                FormLog.AddLog("Start BackgroundWorkerBefuellen" + "    " + System.DateTime.Now.ToString());
                BackgroundWorkerTest.DoWork += BackgroundWorkerCommands_DoWork;
                //BackgroundWorkerLeeren.RunWorkerCompleted += BackgroundWorkerReg_RunWorkerCompleted;
                BackgroundWorkerTest.RunWorkerAsync(new HelpClass(1, "X20"));
                BackgroundWorkerTest.Dispose();


            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }

        public void SendLeitungenBefuellen()
        {
            if (oComschnitstelle.bereit)
            {
                oComschnitstelle.SendToCOM(Sequenz.LeitungenBefuellen(), true);
                sExpectedStatus = "Z";
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.LeitungenBefuellen());
                FormLog.AddLog("Incoming Data gesendet:" + Sequenz.LeitungenBefuellen() + "    " + System.DateTime.Now.ToString());

                BackgroundWorker BackgroundWorkerBefuellen = new BackgroundWorker();
                FormLog.AddLog("Start BackgroundWorkerBefuellen" + "    " + System.DateTime.Now.ToString());
                BackgroundWorkerBefuellen.DoWork += BackgroundWorkerCommands_DoWork;
                //BackgroundWorkerLeeren.RunWorkerCompleted += BackgroundWorkerReg_RunWorkerCompleted;
                BackgroundWorkerBefuellen.RunWorkerAsync(new HelpClass(1, "X2"));
                BackgroundWorkerBefuellen.Dispose();

            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }

        public void SendProbe1_leeren()
        {
            if (oComschnitstelle.bereit)
            {
                oComschnitstelle.SendToCOM(Sequenz.Probe1_leeren(), true);
                sExpectedStatus = "Z";
                BackgroundWorker BackgroundWorkerLeeren = new BackgroundWorker();
                FormLog.AddLog("Start BackgroundWorkerLeeren" + "    " + System.DateTime.Now.ToString());
                BackgroundWorkerLeeren.DoWork += BackgroundWorkerCommands_DoWork;
                //BackgroundWorkerLeeren.RunWorkerCompleted += BackgroundWorkerReg_RunWorkerCompleted;
                BackgroundWorkerLeeren.RunWorkerAsync(new HelpClass(1, "X3"));
                BackgroundWorkerLeeren.Dispose();
            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }

        public void SendReg()
        {
            if (oComschnitstelle.bereit)
            {
                oComschnitstelle.SendToCOM(Sequenz.ElektrodenReg(), true);
                sExpectedStatus = "Z";
                BackgroundWorker BackgroundWorkerReg = new BackgroundWorker();
                FormLog.AddLog("Start BackgroundWorkerReg" + "    " + System.DateTime.Now.ToString());
                BackgroundWorkerReg.DoWork += BackgroundWorkerCommands_DoWork;
                BackgroundWorkerReg.RunWorkerCompleted += BackgroundWorkerReg_RunWorkerCompleted;
                BackgroundWorkerReg.RunWorkerAsync(new HelpClass(1, "X20"));
                BackgroundWorkerReg.Dispose();
                //  tabControl1.SelectedTab = tabGKommunikation;
            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }


        public void SendLeitungDesk(int p_CountDesItereation, int p_CountSpulItereation)
        {
            CountSpulItereation = p_CountSpulItereation;
            if (oComschnitstelle.bereit)
            {
                Sequenzen_uebertragen_aktiv = true;
                //tabControl1.SelectedTab = tabGKommunikation;
                oComschnitstelle.SendToCOM(Sequenz.LeitungenSpuelen(true), true);
                sExpectedStatus = "Z";
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(true));
                FormLog.AddLog("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(true) + "    " + System.DateTime.Now.ToString());
                MessageBox.Show("Schritt 1: Desinfektion \n 1. Inkubationsgefäße gegen Blindgefäße austauschen! \n 2. Zuleitungen 1, 2, 3, 6, 7 zu Ventil 2 in separates Abfallgefäß führen! \n 3. Puffergefäß gegen Desinfektionsmittelgefäß austauschen!");
                System.Threading.Thread.Sleep(2000);
                oComschnitstelle.SendToCOM(Sequenz.LeitungenSpuelen(false), true);
                sExpectedStatus = "Z";
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(false));
                FormLog.AddLog("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(false) + "    " + System.DateTime.Now.ToString());
                System.Threading.Thread.Sleep(2000);

                Sequenzen_uebertragen_aktiv = false;
                BackgroundWorker BackgroundWorkerDesinfect = new BackgroundWorker();
                FormLog.AddLog("Start BackgroundWorkerDesinfect" + "    " + System.DateTime.Now.ToString());
                BackgroundWorkerDesinfect.RunWorkerCompleted += BackgroundWorkerDesinfect_RunWorkerCompleted;
                BackgroundWorkerDesinfect.DoWork += BackgroundWorkerCommands_DoWork;
                BackgroundWorkerDesinfect.RunWorkerAsync(new HelpClass(p_CountDesItereation, "X18", "X19"));
                BackgroundWorkerDesinfect.Dispose();
            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }

        private void BackgroundWorkerDesinfect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormLog.AddLog("Completed BackgroundWorkerDesinfect" + "    " + System.DateTime.Now.ToString());
            MessageBox.Show("Schritt 2: Spülen \n Desinfektionsmittelgefäß gegen Puffergefäß austauschen!");

            BackgroundWorker BackgroundWorkerFlush = new BackgroundWorker();
            FormLog.AddLog("Start BackgroundWorkerFlush" + "    " + System.DateTime.Now.ToString());
            BackgroundWorkerFlush.RunWorkerCompleted += BackgroundWorkerFlush_RunWorkerCompleted;
            BackgroundWorkerFlush.DoWork += BackgroundWorkerCommands_DoWork;
            BackgroundWorkerFlush.RunWorkerAsync(new HelpClass(CountSpulItereation, "X18", "X19"));
            BackgroundWorkerFlush.Dispose();
        }

        private void BackgroundWorkerFlush_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormLog.AddLog("Completed BackgroundWorkerFlush" + "    " + System.DateTime.Now.ToString());
            MessageBox.Show("System desinfiziert und gespült.\n 1. Blindgefäße gegen Inkubationsgefäße austauschen! \n 2. Zuleitungen zu Ventil 2 in die jeweiligen Vorratsgefäße führen!");
        }
        private void BackgroundWorkerCommands_DoWork(object sender, DoWorkEventArgs e)
        {
            Execute_MakroCommands(((HelpClass)e.Argument).iRepeat, ((HelpClass)e.Argument).arrCommands);
        }
        private void BackgroundWorkerMasterEinzelbefehle_DoWork(object sender, DoWorkEventArgs e)
        {
            oComschnitstelle.SendToCOM("p2;1", true);
            Execute_MasterSingleCommands();
            oComschnitstelle.SendToCOM("p2;0", true);
        }

        private void BackgroundWorkerEinzelbefehle_DoWork(object sender, DoWorkEventArgs e)
        {
            oComschnitstelle.SendToCOM("p2;1", true);
            Execute_SingleCommands((int)e.Argument);
            oComschnitstelle.SendToCOM("p2;0", true);
        }
        private void BackgroundWorkerEinzelbefehle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormLog.AddLog("Completed BackgroundWorkerEinzelbefehle" + "    " + System.DateTime.Now.ToString());
            IsMasterThreadActiv = false;
            // MessageBox.Show("Masterablauf erfoglreich absolviert!");
        }

        private void BackgroundWorkerReg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormLog.AddLog("Completed BackgroundWorkerReg" + "    " + System.DateTime.Now.ToString());
            MessageBox.Show("Elektroden wurden regeneriert!");
        }
        private void BackgroundWorkerSendSequenz_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Sequenzen_uebertragen_aktiv = false;
            MessageBox.Show("Sequenzen wurden an das Gerät übertragen!");
            FormLog.AddLog("Sequenzen wurden an das Gerät übertragen!" + "    " + System.DateTime.Now.ToString());
        }


        public void SendFromConsole(string p_value)
        {
            if (p_value == "x")
            {
                Abbruch = true;
            }
            else
            {
                Abbruch = false;
            }
            oComschnitstelle.SendToCOM(p_value, true);
            FormLog.AddLog(p_value);
        }
        public void SendToCOM(string p_Command)
        {
            FormLog.AddLog("Send: " + p_Command);
            sExpectedStatus = "Z";
            oComschnitstelle.SendToCOM(p_Command, true);
        }


        public void StartManuelleMessung(int p_Zellspannung)
        {

            if (!oComschnitstelle.bereit) MessageBox.Show("Manuelle Messung im laufenden Gerätebetrieb nicht möglich!");
            else
            {
                oComschnitstelle.SendToCOM("p1.1", true);
                System.Threading.Thread.Sleep(2000);
                oComschnitstelle.SendToCOM("U" + p_Zellspannung.ToString(), true);
                System.Threading.Thread.Sleep(2000);
                oComschnitstelle.SendToCOM("M", true);
                bIsManuelleMessung = true;
            }
        }

        public void StoppManuelleMessung()
        {
            if (tmrMesswerteTimer != null)
            {
                bStopTimer = true;
                tmrMesswerteTimer.Stop();
                bZyklusActive = false;
            }
            oComschnitstelle.SendToCOM("p1,0", true);
            System.Threading.Thread.Sleep(500);
            oComschnitstelle.SendToCOM("U000", true);
            bStopTimer = false;
        }

        public void UebertragenMakros()
        {
            Abbruch = false;
            List<String> lstCommands = new List<string>();
            List<int> IDs;
            IDs = DBMain.GetAllSequenzIDWithMemory();

            foreach (int ID in IDs)
            {

                lstCommands.Add(DBMain.GetSequenzByID(ID));
                Console.WriteLine(DBMain.GetSequenzByID(ID));
                FormLog.AddLog(DBMain.GetSequenzByID(ID));
            }

            Sequenzen_uebertragen_aktiv = true;
            BackgroundWorker BackgroundWorkerSendSequenz = new BackgroundWorker();
            FormLog.AddLog("Start BackgroundWorkerSendSequenz" + "    " + System.DateTime.Now.ToString());

            BackgroundWorkerSendSequenz.RunWorkerCompleted += BackgroundWorkerSendSequenz_RunWorkerCompleted;
            BackgroundWorkerSendSequenz.DoWork += BackgroundWorkerCommands_DoWork;
            BackgroundWorkerSendSequenz.RunWorkerAsync(new HelpClass(1, lstCommands.ToArray()));
            BackgroundWorkerSendSequenz.Dispose();
        }

        #endregion



        public void port_DataReceived(string p_Status)
        {

            string steuerzeichen = p_Status.Substring(0, 1);
            string sMsg;
            FormLog.AddLog("Data received from device:  " + p_Status + "   expected status: " + sExpectedStatus);

            if (steuerzeichen == sExpectedStatus || steuerzeichen == "E" || p_Status == sMakroEndeZeichen || steuerzeichen == "M" || steuerzeichen == "Z")
                switch (steuerzeichen)
                {
                    case "M":

                        if (!bStopTimer && !bIgnoreNewMeasurements)  //false && false beim ersten Aufruf
                        {
                            if (!bZyklusActive) // false beim ersten Aufruf
                            {
                                try
                                {
                                    sZyklus = DBMain.CreateZyklus();
                                    DBMain.SaveMeasurements();
                                }
                                catch (Exception e)
                                {
                                    FormLog.AddLog("Beim Zugriff auf die Datenbank trat folgende Exception auf: " + e.Message);
                                    oComschnitstelle.NotStop();
                                    SaveLog();
                                    MessageBox.Show("Beim Zugriff auf die Datenbank trat folgende Exception auf (Nr.101): " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }

                            string[] words = p_Status.Split(',');
                            string Sensor1a = words[0].Substring(1, words[0].Length - 1);
                            Sensor1a = Sensor1a.Replace(".", ",");
                            string Sensor2b = words[1].Substring(0, words[1].Length);
                            Sensor2b = Sensor2b.Replace(".", ",");
                            try
                            {
                                DBMain.SetMeasurements(Sensor1a, Sensor2b, sZyklus);
                            }
                            catch (Exception e)
                            {
                                FormLog.AddLog("Beim Zugriff auf die Datenbank trat folgende Exception auf: " + e.Message);
                                oComschnitstelle.NotStop();
                                SaveLog();
                                MessageBox.Show("Beim Zugriff auf die Datenbank trat folgende Exception auf (Nr.102): " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                            if (tmrMesswerteTimer == null)
                            {
                                tmrMesswerteTimer = new System.Timers.Timer();
                                tmrMesswerteTimer.Enabled = false;

                            }
                            if (tmrMesswerteTimer.Enabled == false)
                            {
                                tmrMesswerteTimer = new System.Timers.Timer();
                                iTickInterval = Convert.ToInt32(Messintervall);
                                tmrMesswerteTimer.Interval = iTickInterval * 1000;  //s zu ms
                                tmrMesswerteTimer.Elapsed += new ElapsedEventHandler(Execute);
                                ende = Convert.ToInt32(Messdauer);
                                ende = ende * 60; /// iTickInterval;
                                iTickAktuell = 0;
                                tmrMesswerteTimer.Start();
                            }
                        }
                        else bStopTimer = false;
                        break;

                    case "Z":

                        if (sExpectedStatus == sMakroEndeZeichen && p_Status == sMakroEndeZeichen)
                        {
                            System.Threading.Thread.Sleep(500);
                            oComschnitstelle.bereit = true;
                        }

                        if (sExpectedStatus == "M" && p_Status == sMakroEndeZeichen)
                        {
                            //der Elektrodentest macht dies notwendig
                            System.Threading.Thread.Sleep(500);
                            oComschnitstelle.bereit = true;
                        }
                        if (/*Sequenzen_uebertragen_aktiv == true && */sExpectedStatus == "Z")
                        {
                            System.Threading.Thread.Sleep(500);
                            oComschnitstelle.bereit = true;
                        } // bei sequenzübertragung wird ohne stautsabfrage fortegesetzt



                        break;

                    case "s":
                        switch (p_Status)
                        {
                            case "s00":
                                oComschnitstelle.bereit = true;
                                FormLog.AddLog("Status s00: Empfangsbereit");
                                break;

                            case "s04":
                                oComschnitstelle.bereit = true;
                                FormLog.AddLog("Status s04: Ventil 1 in Bewegung");
                                break;

                            case "s08":
                                oComschnitstelle.bereit = true;
                                FormLog.AddLog("Status s08: Ventil 2 in Bewegung");
                                break;

                            case "s10":
                                System.Threading.Thread.Sleep(1000);
                                FormLog.AddLog("Status s10: Diluter Flüssigkeit aktiv");
                                break;

                            case "s20":
                                oComschnitstelle.bereit = true;
                                FormLog.AddLog("Status s20: Diluter Begasung aktiv");
                                break;

                            case "s24":
                                oComschnitstelle.bereit = true;
                                FormLog.AddLog("Status s24: Diluter Begasung aktiv und Ventil 1 in Bewegung");
                                break;

                            case "s28":
                                oComschnitstelle.bereit = true;
                                FormLog.AddLog("Status s28: Diluter Begasung aktiv und Ventil 2 in Bewegung");
                                break;

                            case "s30":
                                System.Threading.Thread.Sleep(1000);
                                FormLog.AddLog("Status s30: Diluter Begasung aktiv und Diluter Flüssigkeit aktiv");
                                break;

                            case "s40":
                                System.Threading.Thread.Sleep(5000);
                                FormLog.AddLog("Status s40: Wartezeit läuft");
                                break;

                            case "s60":
                                System.Threading.Thread.Sleep(5000);
                                FormLog.AddLog("Status s60: Diluter Begasung aktiv und Wartezeit läuft");
                                break;
                            /*default:
                                System.Threading.Thread.Sleep(30000);
                                if (CountUndefinedStatus != 5)
                                {
                                    CountUndefinedStatus++;
                                    AbfrageStatus();
                                }
                                break;*/
                        }

                        break;
                    case "E":
                        switch (p_Status)
                        {
                            case "E01":
                                FormLog.AddLog("Unbekanntes Kommando! Überprüfen Sie bitte ihre Sequenz auf Fehler.");
                                break;
                            case "E02":
                                FormLog.AddLog("Unzulässiges Element! Überprüfen Sie bitte ihre Sequenz auf Fehler.");
                                break;
                            case "E03":
                                FormLog.AddLog("Unzulässiges Argument! Überprüfen Sie bitte ihre Sequenz auf Fehler.");
                                break;
                            default:
                                FormLog.AddLog("Unbekannter Fehler!");
                                break;
                        }
                        oComschnitstelle.bereit = false;
                        oComschnitstelle.SendToCOM("x", true);
                        sExpectedStatus = ("Z");
                        break;

                    default: break;
                }
        }


        private void Execute(Object myObject, EventArgs myEventArgs)
        {
            tmrMesswerteTimer.Stop();
            if (iTickAktuell <= ende && ende != 0)
            {
                // Restarts the timer and increments the counter.
                bZyklusActive = true;
                oComschnitstelle.SendToCOM("M", true);
                if (!IsWithMakro)
                    sExpectedStatus = "M";
                iTickAktuell = iTickAktuell + iTickInterval;
                tmrMesswerteTimer.Enabled = true;
            }
            else
            {
                iTickAktuell = iTickAktuell + iTickInterval;
                tmrMesswerteTimer.Close();
                bZyklusActive = false;

                if (!bIgnoreNewMeasurements)
                {
                    bIgnoreNewMeasurements = true;
                    tmrAfterAllMesswerte = new System.Timers.Timer();
                    tmrAfterAllMesswerte.Enabled = false;


                    tmrAfterAllMesswerte.Interval = 100000;  // 10 ms
                    tmrAfterAllMesswerte.Elapsed += new ElapsedEventHandler(tmrMesswerteTimerOnTick);

                    tmrAfterAllMesswerte.Start(); //startet er direkt mit den ereignis oder erst nach 10 sek?
                }

                if (bIsManuelleMessung)
                {
                    oComschnitstelle.SendToCOM("p1,0", true);
                    System.Threading.Thread.Sleep(500);
                    oComschnitstelle.SendToCOM("U000", true);
                }
                try
                {
                    DBMain.SaveMeasurements(); // speichern der Daten nach dem Ende eines Messzyklus
                }
                catch (Exception e)
                {
                    FormLog.AddLog("Beim Zugriff auf die Datenbank trat folgende Exception auf: " + e.Message);
                    oComschnitstelle.NotStop();
                    SaveLog();
                    MessageBox.Show("Beim Zugriff auf die Datenbank trat folgende Exception auf (Nr.103): " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                oComschnitstelle.bereit = true; //neue Befehle können aufgenommen werden
                // Die Status Abfrage fürte zu Fehlern im Automatisierten Betrieb. Wenn Status Abfrage Nötig wieder Einschalten
                // AbfrageStatus();
            }

        }

        public void AbfrageStatus()
        {
            FormLog.AddLog("Gesendet : s");
            sExpectedStatus = "s";
            oComschnitstelle.SendToCOM("s", true);
        }


        private void ResponsetimerTick(Object myObject, EventArgs myEventArgs)
        {
            FormLog.AddLog("Error:---------Gerät reagiert nicht, erneute Statusabfrage. " + DateTime.Now);
            AbfrageStatus();

        }
        private void Execute_MasterSingleCommands()
        {

            if (tmrResponsetimer == null)
            {
                tmrResponsetimer = new System.Timers.Timer();
                tmrResponsetimer.Enabled = false;
            }
            if (tmrResponsetimer.Enabled == false)
            {
                tmrResponsetimer.Interval = Responsetime * 60 * 1000;  //s zu ms
                tmrResponsetimer.Elapsed += new ElapsedEventHandler(ResponsetimerTick);

            }

            List<String> lstCommands = new List<string>();
            List<int> IDs;
            IDs = null;
            DataTable dt = DBMain.GetGroupedMasterablauf();
            dt.DefaultView.Sort = "Reihenfolge_Master ASC";
            foreach (DataRow row in dt.Rows)
            {
                string Name = row.ItemArray[0].ToString();
                int Iterationszahl = Convert.ToInt32(row.ItemArray[2].ToString());

                IDs = DBMain.GetSequenzIDsFromMasterablauf(Name);



                FormLog.AddLog("Starte Masterablauf " + Name + DateTime.Now);

                for (int j = 0; j < Iterationszahl; j++)
                {
                    if (Abbruch == true) return;
                    FormLog.AddLog("Masterzyklus: " + (j + 1).ToString());
                    //FormLog.SetLabelForMaster("Masterzyklus: " + (j + 1).ToString());
                    foreach (int ID in IDs)
                    {
                        string SequenzName = DBMain.GetSequenzNameByID(ID);
                        if (Abbruch == true) return;
                        try
                        {
                            lstCommands = DBMain.GetSequenzByIDAsList(ID);
                        }
                        catch (Exception e)
                        {
                            FormLog.AddLog("Beim Zugriff auf die Datenbank trat folgende Exception auf: " + e.Message);
                            oComschnitstelle.NotStop();
                            SaveLog();
                            MessageBox.Show("Beim Zugriff auf die Datenbank trat folgende Exception auf (Nr.105): " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        FormLog.AddLog("Starte Sequenz mit ID: " + SequenzName);
                        //  FormLog.SetLabelForSequenz(SequenzName);
                        for (int i = 0; i < lstCommands.Count(); i++)
                        {
                            if (Abbruch == true) return;
                            //Pufferzeit mitschicken wenn der Befehl lange zum abarbeiten braucht und eine eventbehandlung stattfindet, wenn der Thread fertig ist
                            Boolean bLock = false;

                            FormLog.AddLog("Akuteller Befehl : " + lstCommands[i]);
                            if (lstCommands[i][0] == 'W')
                            {
                                string[] sTime = lstCommands[i].Split(',');
                                string[] sMin = sTime[0].Split('W');
                                sExpectedStatus = "Z";
                                FormLog.AddLog("Wartezeit geht los " + DateTime.Now);
                                oComschnitstelle.SendToCOM(lstCommands[i], false);
                                if (!GlobalVar.IsTest) System.Threading.Thread.Sleep((Convert.ToInt32(sMin[1]) * 60 * 1000) + Convert.ToInt32(sTime[1]) * 1000);
                                FormLog.AddLog("Wartezeit ende " + DateTime.Now);
                            }
                            else
                                if (lstCommands[i] == "M")
                                {
                                    if (Abbruch == true) return;
                                    sExpectedStatus = "M";
                                    oComschnitstelle.SendToCOM(lstCommands[i], false);
                                    FormLog.AddLog("Messwert gesendet " + DateTime.Now);
                                    if (!GlobalVar.IsTest) System.Threading.Thread.Sleep((Messdauer * 60 * 1000) + 2000); //während er wartet müsste der Messwerttimer starten
                                    FormLog.AddLog("Ende Messung " + DateTime.Now);
                                }
                                else
                                {

                                    do
                                    {
                                        if (Abbruch == true) return;
                                        sExpectedStatus = "Z";
                                        if (oComschnitstelle.bereit == true && !bLock)
                                        {
                                            oComschnitstelle.SendToCOM(lstCommands[i], false);
                                            tmrResponsetimer.Start();
                                            if (!GlobalVar.IsTest) System.Threading.Thread.Sleep(1000);
                                            bLock = true;
                                        }
                                    } while (oComschnitstelle.bereit == false); //Somit wartet er bis das erwartete Z den Port für bereit erklärt, die Befehle M und W benötigen keine explizites warten
                                    tmrResponsetimer.Stop();
                                }

                            do
                            {
                                if (Abbruch == true) return;
                                if (!GlobalVar.IsTest) AbfrageStatus(); //Warte bis neuer Befehl gesendet werden kann
                                if (!GlobalVar.IsTest) Thread.Sleep(2000); //um zu verhindern dass das Gerät mit Abfragen zugespamt wird (führt sonst zu fehlern)
                            } while (oComschnitstelle.bereit == false);

                            FormLog.AddLog("Akuteller Befehl abgearbeitet: " + lstCommands[i]);
                        }
                        FormLog.AddLog("Beende Sequenz");
                    }
                }
                FormLog.AddLog("Ende Masterablauf" + DateTime.Now);
                SaveLog();
            }
        }



        private void Execute_SingleCommands(int ID)
        {

            if (tmrResponsetimer == null)
            {
                tmrResponsetimer = new System.Timers.Timer();
                tmrResponsetimer.Enabled = false;
            }
            if (tmrResponsetimer.Enabled == false)
            {
                tmrResponsetimer.Interval = Responsetime * 60 * 1000;  //s zu ms
                tmrResponsetimer.Elapsed += new ElapsedEventHandler(ResponsetimerTick);

            }

            List<String> lstCommands = new List<string>();


            string SequenzName = DBMain.GetSequenzNameByID(ID);
            if (Abbruch == true) return;
            try
            {
                lstCommands = DBMain.GetSequenzByIDAsList(ID);
            }
            catch (Exception e)
            {
                FormLog.AddLog("Beim Zugriff auf die Datenbank trat folgende Exception auf: " + e.Message);
                oComschnitstelle.NotStop();
                SaveLog();
                MessageBox.Show("Beim Zugriff auf die Datenbank trat folgende Exception auf (Nr.105): " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormLog.AddLog("Starte Sequenz mit ID: " + SequenzName);
            //  FormLog.SetLabelForSequenz(SequenzName);
            for (int i = 0; i < lstCommands.Count(); i++)
            {
                if (Abbruch == true) return;
                //Pufferzeit mitschicken wenn der Befehl lange zum abarbeiten braucht und eine eventbehandlung stattfindet, wenn der Thread fertig ist
                Boolean bLock = false;

                FormLog.AddLog("Akuteller Befehl : " + lstCommands[i]);
                if (lstCommands[i][0] == 'W')
                {
                    string[] sTime = lstCommands[i].Split(',');
                    string[] sMin = sTime[0].Split('W');
                    sExpectedStatus = "Z";
                    FormLog.AddLog("Wartezeit geht los " + DateTime.Now);
                    oComschnitstelle.SendToCOM(lstCommands[i], false);
                    if (!GlobalVar.IsTest) System.Threading.Thread.Sleep((Convert.ToInt32(sMin[1]) * 60 * 1000) + Convert.ToInt32(sTime[1]) * 1000);
                    FormLog.AddLog("Wartezeit ende " + DateTime.Now);
                }
                else
                    if (lstCommands[i] == "M")
                    {
                        if (Abbruch == true) return;
                        sExpectedStatus = "M";
                        oComschnitstelle.SendToCOM(lstCommands[i], false);
                        FormLog.AddLog("Messwert gesendet " + DateTime.Now);
                        if (!GlobalVar.IsTest) System.Threading.Thread.Sleep((Messdauer * 60 * 1000) + 2000); //während er wartet müsste der Messwerttimer starten
                        FormLog.AddLog("Ende Messung " + DateTime.Now);
                    }
                    else
                    {
                        do
                        {
                            if (Abbruch == true) return;
                            sExpectedStatus = "Z";
                            if (oComschnitstelle.bereit == true && !bLock)
                            {
                                oComschnitstelle.SendToCOM(lstCommands[i], false);
                                tmrResponsetimer.Start();
                                if (!GlobalVar.IsTest) System.Threading.Thread.Sleep(1000);
                                bLock = true;
                            }
                        } while (oComschnitstelle.bereit == false); //Somit wartet er bis das erwartete Z den Port für bereit erklärt, die Befehle M und W benötigen keine explizites warten
                        tmrResponsetimer.Stop();
                    }
                do
                {
                    if (Abbruch == true) return;
                    if (!GlobalVar.IsTest) AbfrageStatus(); //Warte bis neuer Befehl gesendet werden kann
                    if (!GlobalVar.IsTest) Thread.Sleep(2000); //um zu verhindern dass das Gerät mit Abfragen zugespamt wird (führt sonst zu fehlern)
                } while (oComschnitstelle.bereit == false);

                FormLog.AddLog("Akuteller Befehl abgearbeitet: " + lstCommands[i]);
            }
            FormLog.AddLog("Beende Sequenz");

            SaveLog();
        }

        private void Execute_Makro(string Makro)
        {
            do
            {
                if (Abbruch == true) return;
                System.Threading.Thread.Sleep(2000);
                if (oComschnitstelle.bereit == true)
                {
                    sExpectedStatus = "Z";
                    FormLog.AddLog("Send: " + Makro);
                    oComschnitstelle.SendToCOM(Makro, false);
                    System.Threading.Thread.Sleep(2000);

                }
            } while (oComschnitstelle.bereit == false);

            sExpectedStatus = "ZY"; //Makro wurde angenommen
            FormLog.AddLog("Makro wurde übertragen, COM wird solange Blockiert bis Makro abgearbeitet wurde (ZY)");
            oComschnitstelle.bereit = false; //deswegen warten wir solange bis es auch abgearbeitet wurde und uns ein ZY zurück gibt
            do
            {
                if (Abbruch == true) return;
                if (!GlobalVar.IsTest) Thread.Sleep(2000);
            } while (oComschnitstelle.bereit == false);
            FormLog.AddLog("Makro wurde abgearbeitet");
        }
        private void Execute_MakroCommands(int repeat, params string[] Commands)
        {
            for (int j = 0; j < repeat; j++)
            {
                for (int i = 0; i < Commands.Count(); i++)
                {
                    Execute_Makro(Commands[i]);
                }
            }
        }


        private void tmrMesswerteTimerOnTick(Object myObject, EventArgs myEventArgs)
        {
            bIgnoreNewMeasurements = false;
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
