﻿/*Einlesen der Steuerzeichen und Übergabe der Eingabekomandos
  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Timers;

namespace PharMS_Steuerung.Funktionen
{// [STAThread] 
    class COM
    {// Create the serial port with basic settings
        public string Status;
        private string sMakroEndeZeichen;
        private string[] empfangene_snr = new string[50];
        private string sExpectedStatus;
        private string sZyklus;
        public bool bStopTimer = false;
        public bool bZyklusActive = false;
        public bool bIsManuelleMessung = false;
        public SerialPort port;
        public Form1 tempForm = new Form1();
        public bool bereit = true;
        public bool bIgnoreNewMeasurements=false;
        public static bool Sequenzen_uebertragen_aktiv = false;
        int CountUndefinedStatus = 0;
        public System.Timers.Timer tmrMesswerteTimer;
        public System.Timers.Timer tmrAfterAllMesswerte;
        /// <summary>
        /// Öffnet COM Port und aktiviert data Recieved
        /// </summary>
        /// static System.Windows.Forms.Timer Zeitsteuerung = new System.Windows.Forms.Timer();
        /// Timer 
        private int iTickInterval, iTickAktuell;
        public static int ende;



        public COM(Form1 Ausgabefenster)
        {
            tempForm = Ausgabefenster;
            CfgFile Config = new CfgFile("Config.ini");
            string ComPort = Config.getValue("COM", "Port", false);
            sMakroEndeZeichen = Config.getValue("Steuerzeichen", "MakroEnde", false);
            System.Console.Out.WriteLine("Das ist Com Port  " + ComPort);
            port = new SerialPort(ComPort, 9600, Parity.None, 8, StopBits.One);
            Console.WriteLine("Incoming Data:");

            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            if (port.IsOpen) return;
            else { port.Open(); bereit = true; };
        }
        private void port_DataReceived(object sender,
          SerialDataReceivedEventArgs e)
        {
            if (!port.IsOpen) return;

            Status = port.ReadLine();
            Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG(Status, tempForm);
            string steuerzeichen = Status.Substring(0, 1);
            string sMsg;
            tempForm.stlLog.Add("Data received from device:  " + Status + "   expected status: " + sExpectedStatus + "     " + System.DateTime.Now.ToString());
            if (steuerzeichen == sExpectedStatus || steuerzeichen == "E" || Status == sMakroEndeZeichen || steuerzeichen == "M" || steuerzeichen == "Z")
                switch (steuerzeichen)
                {
                    case "M":

                        if (!bStopTimer && !bIgnoreNewMeasurements)  //false && false beim ersten Aufruf
                        {
                            if (!bZyklusActive) // false beim ersten Aufruf
                            {
                                sZyklus = tempForm.DBMain.CreateZyklus();
                                tempForm.DBMain.SaveMeasurements();
                            }

                            string[] words = Status.Split(',');
                            string Sensor1a = words[0].Substring(1, words[0].Length - 1);
                            Sensor1a = Sensor1a.Replace(".", ",");
                            string Sensor2b = words[1].Substring(0, words[1].Length);
                            Sensor2b = Sensor2b.Replace(".", ",");
                            tempForm.DBMain.SetMeasurements(Sensor1a, Sensor2b, sZyklus);



                            if (tmrMesswerteTimer == null)
                            {
                                tmrMesswerteTimer = new System.Timers.Timer();
                                tmrMesswerteTimer.Enabled = false;

                            }
                            if (tmrMesswerteTimer.Enabled == false)
                            {
                                tmrMesswerteTimer = new System.Timers.Timer();
                                iTickInterval = Convert.ToInt32(tempForm.numeric_Intervall.Value);
                                tmrMesswerteTimer.Interval = iTickInterval * 1000;  //s zu ms
                                tmrMesswerteTimer.Elapsed += new ElapsedEventHandler(Execute);
                                ende = Convert.ToInt32(tempForm.numeric_Messdauer.Value);
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

                        if (sExpectedStatus == sMakroEndeZeichen && Status == sMakroEndeZeichen)
                        {
                            System.Threading.Thread.Sleep(500);
                            bereit = true;
                        }

                        if (/*Sequenzen_uebertragen_aktiv == true && */sExpectedStatus == "Z")
                        {
                            System.Threading.Thread.Sleep(500);
                            bereit = true;
                        } // bei sequenzübertragung wird ohne stautsabfrage fortegesetzt



                        break;

                    case "s":
                        switch (Status)
                        {
                            case "s00":
                                bereit = true;
                                CountUndefinedStatus = 0;
                                break;

                            case "s20":

                                bereit = true;
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
                        switch (Status)
                        {
                            case "E01":
                                sMsg = "Unbekanntes Kommando! Überprüfen Sie bitte ihre Sequenz auf Fehler.";
                                tempForm.Invoke(new Action(() => { MessageBox.Show(tempForm, sMsg); }));
                                break;
                            case "E02":
                                sMsg = "Unzulässiges Element! Überprüfen Sie bitte ihre Sequenz auf Fehler.";
                                tempForm.Invoke(new Action(() => { MessageBox.Show(tempForm, sMsg); }));
                                break;
                            case "E03":
                                sMsg = "Unzulässiges Argument! Überprüfen Sie bitte ihre Sequenz auf Fehler.";
                                tempForm.Invoke(new Action(() => { MessageBox.Show(tempForm, sMsg); }));
                                break;
                            default:
                                sMsg = "Unbekannter Fehler!";
                                tempForm.Invoke(new Action(() => { MessageBox.Show(tempForm, sMsg); }));
                                break;
                        }
                        bereit = false;
                        port.WriteLine("x");
                        sExpectedStatus = ("Z");
                        break;

                    default: break;
                }

            //   Console.WriteLine("Eingelesen von Com 3" + eingabe + "/" + steuerzeichen);
        }

        private void Execute(Object myObject, EventArgs myEventArgs)
        {
            tmrMesswerteTimer.Stop();
            if (iTickAktuell <= ende && ende != 0)
            {
                // Restarts the timer and increments the counter.
                bZyklusActive = true;
                port.WriteLine("M");
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

                if(bIsManuelleMessung)
                {
                    SendToCOM("p1,0", true);
                    System.Threading.Thread.Sleep(500);
                    SendToCOM("U000", true);
                }

                tempForm.DBMain.SaveMeasurements(); // speichern der Daten nach dem Ende eines Messzyklus

                AbfrageStatus();
            }

        }
        private void tmrMesswerteTimerOnTick(Object myObject, EventArgs myEventArgs)
        {
            bIgnoreNewMeasurements = false;
        }

        /// <summary>
        /// Sendet einen String an geöffneten com port
        /// </summary>
        /// <param name="Caption">String</param>

        public bool SendToCOM(String Caption, bool bForce)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("COM nicht verbunden");
                return false;

            }
            if (Caption != "")
            {
                if (bereit == true || bForce == true)
                {
                    tempForm.stlLog.Add("Gesendet : " + Caption + "    " + System.DateTime.Now.ToString());
                    Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : " + Caption, tempForm);
                    port.WriteLine(Caption);
                    if (Caption[0] == 'X')
                        sExpectedStatus = sMakroEndeZeichen;
                    else
                        sExpectedStatus = "Z";

                    bereit = false;
                    return true;
                }
                else
                    /* if (bCheckStatus)
                     {
                         Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : s", tempForm);
                         AbfrageStatus();
                     }*/
                    return false;
            }
            else return false;
        }
        public void COMDisconnect()
        {
            port.Close();
        }

        public void AbfrageStatus()
        {
            if (!port.IsOpen) return;
            Thread.Sleep(3000); //um zu verhindern dass das Gerät mit Abfragen zugespamt wird (führt sonst zu fehlern)
            // Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : s", tempForm);
            port.WriteLine("s");
            sExpectedStatus = "s";
        }

        public void NotStop()
        {
            if (!port.IsOpen) return;
            Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : s", tempForm);

            port.WriteLine("x");
            sExpectedStatus = ("Z");
            Thread.Sleep(1000);
            port.WriteLine("p1.0");
            Thread.Sleep(1000);
            sExpectedStatus = ("Z");
            port.WriteLine("d0");
            Thread.Sleep(1000);
            sExpectedStatus = ("Z");
            port.WriteLine("U000");
            Thread.Sleep(1000);
            sExpectedStatus = ("Z");
            bereit = true;
        }



        public void Execute_Commands(int repeat, params string[] Commands)
        {
          if( String.Join("", Commands.Select(p => p.ToString()).ToArray()).Length>512)
          {
              MessageBox.Show("Die Befehlsfolge ist größere als 512 Zeichen");
          }
            for (int j = 0; j < repeat; j++)
            {
                for (int i = 0; i < Commands.Count(); i++)
                {
                    Boolean Lauf = true; //Pufferzeit mitschicken wenn der Befehl lange zum abarbeiten braucht und eine eventbehandlung stattfindet, wenn der Thread fertig ist
                    do
                    {
                        if (tempForm.Abbruch == true) return;
                        Lauf = SendToCOM(Commands[i], false);
                        if (Lauf == true) Console.WriteLine("Line: " + Commands[i]);
                        if (Lauf == true) System.Threading.Thread.Sleep(1000);

                    } while (Lauf == false);
                }
            }
        }

        public void Execute_Ablauf()
        {
            List<string> lstMaster = tempForm.DBMain.GetMasterablauf();

            for (int z = 0; z < tempForm.Durchläufe; z++)
            {
                for (int i = 0; i < lstMaster.Count; i++) // warum hast du davor mit 1 angefangen und warum befindet sich die Methode überhaupt in der MainForm?
                {
                    Boolean Lauf = true;
                    do
                    {
                        if (tempForm.Abbruch == true) return;
                        Lauf = SendToCOM("X" + lstMaster[i], false);
                        if (Lauf == true) Console.WriteLine("Line: " + i + ";" + lstMaster.Count + ";" + "X" + lstMaster[i]);
                        if (Lauf == true) tempForm.stlLog.Add("Line: " + i + ";" + lstMaster.Count + ";" + "X" + lstMaster[i]);
                        System.Threading.Thread.Sleep(1000);

                    } while (Lauf == false);
                }

            }
            tempForm.stlLog.Add("Completed threadAblaufStart" + "    " + System.DateTime.Now.ToString());
        }
    }
}

