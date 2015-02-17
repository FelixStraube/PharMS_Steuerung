using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.IO;
using System.Timers;

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
        private int CountUndefinedStatus = 0;


        public System.Timers.Timer tmrMesswerteTimer;
        public System.Timers.Timer tmrAfterAllMesswerte;
        public bool bStopTimer = false;
        public bool bZyklusActive = false;
        public bool bIsManuelleMessung = false;
        public bool bIgnoreNewMeasurements = false;
        public bool Sequenzen_uebertragen_aktiv = false;
        public int ende;
        public int Messdauer, Messintervall;
        public bool IsWithMakro;


        public List<string> stlLog;
        public SQLMain DBMain;
        public bool Abbruch; //Abruch der Kommunikation 
        public bool Connection; //eher nach COM auslagern 
        #endregion


        #region Grundlegendefunktionen
        public Communicator(SQLMain p_DBMain, Consolen_LOG p_FormLog)
        {
            stlLog = new List<string>();
            DBMain = p_DBMain;
            FormLog = p_FormLog;

            CfgFile Config = new CfgFile("Config.ini");
            sMakroEndeZeichen = Config.getValue("Steuerzeichen", "MakroEnde", false);

        }
        public void SaveLog()
        {
            File.WriteAllLines("LogCOM.txt", stlLog);
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
                stlLog.Add("Start threadAblaufStart" + "    " + System.DateTime.Now.ToString());
                threadAblaufStart.Start();
            }

        }
        public void StartMasterAblaufBefehlsweise(int p_PCountMasterIteration)
        {
            CountMasterIteration = p_PCountMasterIteration;


            Abbruch = false;


            BackgroundWorker BackgroundWorkerEinzelbefehle = new BackgroundWorker();
            stlLog.Add("Start BackgroundWorkerSendSequenz" + "    " + System.DateTime.Now.ToString());
            BackgroundWorkerEinzelbefehle.RunWorkerCompleted += BackgroundWorkerEinzelbefehle_RunWorkerCompleted;
            BackgroundWorkerEinzelbefehle.DoWork += BackgroundWorkerEinzelbefehle_DoWork;
            BackgroundWorkerEinzelbefehle.RunWorkerAsync();
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

                        stlLog.Add("Gesendet : " + lstMaster[i] + "    " + System.DateTime.Now.ToString());
                        FormLog.AddLog("Gesendet : " + lstMaster[i]);

                        if (Lauf == true) Console.WriteLine("Line: " + i + ";" + lstMaster.Count + ";" + "X" + lstMaster[i]);
                        if (Lauf == true) stlLog.Add("Line: " + i + ";" + lstMaster.Count + ";" + "X" + lstMaster[i]);
                        System.Threading.Thread.Sleep(1000);

                    } while (Lauf == false);
                }

            }
            stlLog.Add("Completed threadAblaufStart" + "    " + System.DateTime.Now.ToString());
        }
        #endregion

        #region Controller für Form
        public void SendElektrodenTest()
        {
            if (oComschnitstelle.bereit)
            {
                oComschnitstelle.SendToCOM(Sequenz.ElektrodenTest(), true);
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.ElektrodenTest());
                stlLog.Add("Incoming Data gesendet:" + Sequenz.ElektrodenTest() + "    " + System.DateTime.Now.ToString());
                MessageBox.Show("Zuleitung 7 zu Ventil 2 in Testlösung führen !");//TODO evt abbrechen
                System.Threading.Thread.Sleep(5000);
                oComschnitstelle.SendToCOM("X20", true);
                Console.WriteLine("X20");
                stlLog.Add("X20");

            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }

        public void SendReg()
        {
            if (oComschnitstelle.bereit)
            {
                oComschnitstelle.SendToCOM(Sequenz.ElektrodenReg(), true);
                BackgroundWorker BackgroundWorkerReg = new BackgroundWorker();
                stlLog.Add("Start BackgroundWorkerReg" + "    " + System.DateTime.Now.ToString());
                BackgroundWorkerReg.DoWork += BackgroundWorkerCommands_DoWork;
                BackgroundWorkerReg.RunWorkerCompleted += BackgroundWorkerReg_RunWorkerCompleted;
                BackgroundWorkerReg.RunWorkerAsync(new HelpClass(1, "X20", "W0,01"));
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
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(true));
                stlLog.Add("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(true) + "    " + System.DateTime.Now.ToString());
                MessageBox.Show("Schritt 1: Desinfektion \n 1. Inkubationsgefäße gegen Blindgefäße austauschen! \n 2. Zuleitungen 1, 2, 3, 6, 7 zu Ventil 2 in separates Abfallgefäß führen! \n 3. Puffergefäß gegen Desinfektionsmittelgefäß austauschen!");
                System.Threading.Thread.Sleep(2000);
                oComschnitstelle.SendToCOM(Sequenz.LeitungenSpuelen(false), true);
                Console.WriteLine("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(false));
                stlLog.Add("Incoming Data gesendet:" + Sequenz.LeitungenSpuelen(false) + "    " + System.DateTime.Now.ToString());
                System.Threading.Thread.Sleep(2000);

                Sequenzen_uebertragen_aktiv = false;
                BackgroundWorker BackgroundWorkerDesinfect = new BackgroundWorker();
                stlLog.Add("Start BackgroundWorkerDesinfect" + "    " + System.DateTime.Now.ToString());
                BackgroundWorkerDesinfect.RunWorkerCompleted += BackgroundWorkerDesinfect_RunWorkerCompleted;
                BackgroundWorkerDesinfect.DoWork += BackgroundWorkerCommands_DoWork;
                BackgroundWorkerDesinfect.RunWorkerAsync(new HelpClass(p_CountDesItereation, "X18", "X19", "W0,01"));
                BackgroundWorkerDesinfect.Dispose();
            }
            else MessageBox.Show("Eine Sequenz befindet sich bereits in Bearbeitung");
        }

        private void BackgroundWorkerDesinfect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stlLog.Add("Completed BackgroundWorkerDesinfect" + "    " + System.DateTime.Now.ToString());
            MessageBox.Show("Schritt 2: Spülen \n Desinfektionsmittelgefäß gegen Puffergefäß austauschen!");

            BackgroundWorker BackgroundWorkerFlush = new BackgroundWorker();
            stlLog.Add("Start BackgroundWorkerFlush" + "    " + System.DateTime.Now.ToString());
            BackgroundWorkerFlush.RunWorkerCompleted += BackgroundWorkerFlush_RunWorkerCompleted;
            BackgroundWorkerFlush.DoWork += BackgroundWorkerCommands_DoWork;
            BackgroundWorkerFlush.RunWorkerAsync(new HelpClass(CountSpulItereation, "X18", "X19", "W0,01"));
            BackgroundWorkerFlush.Dispose();
        }

        private void BackgroundWorkerFlush_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stlLog.Add("Completed BackgroundWorkerFlush" + "    " + System.DateTime.Now.ToString());
            MessageBox.Show("System desinfiziert und gespült.\n 1. Blindgefäße gegen Inkubationsgefäße austauschen! \n 2. Zuleitungen zu Ventil 2 in die jeweiligen Vorratsgefäße führen!");
        }
        private void BackgroundWorkerCommands_DoWork(object sender, DoWorkEventArgs e)
        {
            Execute_Commands(((HelpClass)e.Argument).iRepeat, ((HelpClass)e.Argument).arrCommands);
        }
        private void BackgroundWorkerEinzelbefehle_DoWork(object sender, DoWorkEventArgs e)
        {
            Execute_SingleCommands();
        }
        private void BackgroundWorkerEinzelbefehle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stlLog.Add("Completed BackgroundWorkerEinzelbefehle" + "    " + System.DateTime.Now.ToString());
            // MessageBox.Show("Masterablauf erfoglreich absolviert!");
        }

        private void BackgroundWorkerReg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stlLog.Add("Completed BackgroundWorkerReg" + "    " + System.DateTime.Now.ToString());
            MessageBox.Show("Elektroden wurden regeneriert!");
        }
        private void BackgroundWorkerSendSequenz_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Sequenzen_uebertragen_aktiv = false;
            MessageBox.Show("Sequenzen wurden an das Gerät übertragen!");
            stlLog.Add("Sequenzen wurden an das Gerät übertragen!" + "    " + System.DateTime.Now.ToString());
        }


        public void SendFromConsole(string p_value)
        {
            Abbruch = false;
            oComschnitstelle.SendToCOM(p_value, true);
            FormLog.AddLog(p_value);
        }
        public void SendToCOM(string p_Command)
        {
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
                stlLog.Add(DBMain.GetSequenzByID(ID));
            }

            Sequenzen_uebertragen_aktiv = true;
            BackgroundWorker BackgroundWorkerSendSequenz = new BackgroundWorker();

            stlLog.Add("Start BackgroundWorkerSendSequenz" + "    " + System.DateTime.Now.ToString());
            BackgroundWorkerSendSequenz.RunWorkerCompleted += BackgroundWorkerSendSequenz_RunWorkerCompleted;
            BackgroundWorkerSendSequenz.DoWork += BackgroundWorkerCommands_DoWork;
            BackgroundWorkerSendSequenz.RunWorkerAsync(new HelpClass(1, lstCommands.ToArray()));
            BackgroundWorkerSendSequenz.Dispose();
        }

        #endregion



        public void port_DataReceived(string p_Status)
        {

            FormLog.AddLog(p_Status);
            string steuerzeichen = p_Status.Substring(0, 1);
            string sMsg;
            stlLog.Add("Data received from device:  " + p_Status + "   expected status: " + sExpectedStatus + "     " + System.DateTime.Now.ToString());
            if (steuerzeichen == sExpectedStatus || steuerzeichen == "E" || p_Status == sMakroEndeZeichen || steuerzeichen == "M" || steuerzeichen == "Z")
                switch (steuerzeichen)
                {
                    case "M":

                        if (!bStopTimer && !bIgnoreNewMeasurements)  //false && false beim ersten Aufruf
                        {
                            if (!bZyklusActive) // false beim ersten Aufruf
                            {
                                sZyklus = DBMain.CreateZyklus();
                                DBMain.SaveMeasurements();
                            }

                            string[] words = p_Status.Split(',');
                            string Sensor1a = words[0].Substring(1, words[0].Length - 1);
                            Sensor1a = Sensor1a.Replace(".", ",");
                            string Sensor2b = words[1].Substring(0, words[1].Length);
                            Sensor2b = Sensor2b.Replace(".", ",");
                            DBMain.SetMeasurements(Sensor1a, Sensor2b, sZyklus);



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
                        CountUndefinedStatus = 0;   // Counter null da sonst bei langen Sequenzen kein abfragen status nach 5 min möglich währe
                        // AbfrageStatus();

                        if (sExpectedStatus == sMakroEndeZeichen && p_Status == sMakroEndeZeichen)
                        {
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
                                CountUndefinedStatus = 0;
                                break;

                            case "s20":

                                oComschnitstelle.bereit = true;
                                CountUndefinedStatus = 0;
                                break;
                            case "s10":

                                System.Threading.Thread.Sleep(5000);
                                AbfrageStatus();
                                break;

                            case "s30":

                                System.Threading.Thread.Sleep(5000);
                                AbfrageStatus();
                                break;

                            case "s40":

                                System.Threading.Thread.Sleep(5000);
                                AbfrageStatus();
                                break;
                            default:
                                System.Threading.Thread.Sleep(30000);
                                if (CountUndefinedStatus != 5)
                                {
                                    CountUndefinedStatus++;
                                    AbfrageStatus();
                                }
                                break;
                        }

                        break;
                    case "E":
                        switch (p_Status)
                        {
                            case "E01":
                                sMsg = "Unbekanntes Kommando! Überprüfen Sie bitte ihre Sequenz auf Fehler.";
                                //  tempForm.Invoke(new Action(() => { MessageBox.Show(tempForm, sMsg); }));
                                break;
                            case "E02":
                                sMsg = "Unzulässiges Element! Überprüfen Sie bitte ihre Sequenz auf Fehler.";
                                //   tempForm.Invoke(new Action(() => { MessageBox.Show(tempForm, sMsg); }));
                                break;
                            case "E03":
                                sMsg = "Unzulässiges Argument! Überprüfen Sie bitte ihre Sequenz auf Fehler.";
                                //   tempForm.Invoke(new Action(() => { MessageBox.Show(tempForm, sMsg); }));
                                break;
                            default:
                                sMsg = "Unbekannter Fehler!";
                                //   tempForm.Invoke(new Action(() => { MessageBox.Show(tempForm, sMsg); }));
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

                DBMain.SaveMeasurements(); // speichern der Daten nach dem Ende eines Messzyklus

                // Die Status Abfrage fürte zu Fehlern im Automatisierten Betrieb. Wenn Status Abfrage Nötig wieder Einschalten
                // AbfrageStatus();
            }

        }

        public void AbfrageStatus()
        {

            Thread.Sleep(3000); //um zu verhindern dass das Gerät mit Abfragen zugespamt wird (führt sonst zu fehlern)
            FormLog.AddLog("Gesendet : s");
            oComschnitstelle.SendToCOM("s", true);
            sExpectedStatus = "s";
        }

        private void Execute_SingleCommands()
        {
            List<String> lstCommands = new List<string>();
            List<int> IDs;
            IDs = DBMain.GetAllSequenzIDWithMemory();

            for (int j = 0; j < CountMasterIteration; j++)
            {
                foreach (int ID in IDs)
                {
                    lstCommands = DBMain.GetSequenzByIDAsList(ID);
                    FormLog.AddLog("Starte Sequenz");
                    for (int i = 0; i < lstCommands.Count(); i++)
                    {
                        HandleCommand(lstCommands[i]);
                        Boolean Lauf = true; //Pufferzeit mitschicken wenn der Befehl lange zum abarbeiten braucht und eine eventbehandlung stattfindet, wenn der Thread fertig ist
                        do
                        {
                            if (Abbruch == true) return;
                            Lauf = oComschnitstelle.SendToCOM(lstCommands[i], false);
                            if (Lauf == true) FormLog.AddLog("Line: " + lstCommands[i]);
                            if (Lauf == true) System.Threading.Thread.Sleep(1000);

                        } while (Lauf == false);
                    }
                    FormLog.AddLog("Beende Sequenz");
                }
            }
        }

        private void HandleCommand(string sCommand)
        {
            if (sCommand == "M")
                System.Threading.Thread.Sleep(Messdauer*60*1000);

            sExpectedStatus = "Z";

        }
        private void Execute_Commands(int repeat, params string[] Commands)
        {
            for (int j = 0; j < repeat; j++)
            {
                for (int i = 0; i < Commands.Count(); i++)
                {
                    if (Commands[i].Length > 512)
                        MessageBox.Show("Der Befehl ist größere als 512 Zeichen");

                    Boolean Lauf = true; //Pufferzeit mitschicken wenn der Befehl lange zum abarbeiten braucht und eine eventbehandlung stattfindet, wenn der Thread fertig ist
                    do
                    {
                        if (Abbruch == true) return;
                        Lauf = oComschnitstelle.SendToCOM(Commands[i], false);
                        if (Lauf == true) FormLog.AddLog("Line: " + Commands[i]);
                        if (Lauf == true) System.Threading.Thread.Sleep(1000);

                    } while (Lauf == false);
                }
            }
        }


        private void tmrMesswerteTimerOnTick(Object myObject, EventArgs myEventArgs)
        {
            bIgnoreNewMeasurements = false;
        }
    }

    /* if (Caption[0] == 'X')
                        sExpectedStatus = sMakroEndeZeichen;
                    else
                        sExpectedStatus = "Z";*/
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
