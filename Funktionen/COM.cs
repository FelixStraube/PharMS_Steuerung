/*Einlesen der Steuerzeichen und Übergabe der Eingabekomandos
  
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
        private string[] empfangene_snr = new string[50];
        public SerialPort port;

        public Form1 tempForm = new Form1();
        public bool bereit;

        public System.Timers.Timer tmrMesswerteTimer;
        /// <summary>
        /// Öffnet COM Port und aktiviert data Recieved
        /// </summary>
        /// static System.Windows.Forms.Timer Zeitsteuerung = new System.Windows.Forms.Timer();
        /// Timer 
        private int iTickInterval, iTickAktuell;
        static int ende;



        public COM(Form1 Ausgabefenster)
        {
            tempForm = Ausgabefenster;
            CfgFile Config = new CfgFile("Config.ini");
            string ComPort = Config.getValue("COM", "Port", false);
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
            //eingabe = port.ReadExisting();
            Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG(Status, tempForm);
            string steuerzeichen = Status.Substring(0, 1);
            string sMsg;
            tempForm.stlLog.Add("Data received from device:  " + Status + "     " + System.DateTime.Now.ToString());

            switch (steuerzeichen)
            {
                case "M":
                    if (tempForm.rbManuelleMessung.Checked == true)
                    {
                        Funktionen.Datenerfassen Ausgabe_manuel = new Datenerfassen(Status, tempForm);
                    }
                    if (tempForm.rbAktiveMessung.Checked == true)
                    {
                        if (tmrMesswerteTimer == null)
                        {
                            tmrMesswerteTimer = new System.Timers.Timer();
                            tmrMesswerteTimer.Enabled = false;
                        }
                        if (tmrMesswerteTimer.Enabled == true)
                        {
                            Funktionen.Datenerfassen Ausgabe_automatisch = new Datenerfassen(Status, tempForm);
                        }
                        else
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

                    break;

                case "Z":
                    AbfrageStatus();
                    break;

                case "s":
                    switch (Status)
                    {
                        case "s00":
                            bereit = true;
                            break;

                        case "s20":
                            /*if (tempForm.label6.Text == "In Arbeit")
                            {
                                tempForm.change_Label("Bereit", tempForm.label6);
                            }*/

                            bereit = true;
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
                        default: break;
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
                    SendToCOM("x");
                    break;

                default: break;
            }

            //   Console.WriteLine("Eingelesen von Com 3" + eingabe + "/" + steuerzeichen);
        }

        private void Execute(Object myObject, EventArgs myEventArgs)
        {
            if (iTickAktuell == ende)
            {
                Funktionen.Datenerfassen test = new Funktionen.Datenerfassen("---------,---------", tempForm);
                //Live chart cler und in Datenfeld aufnehmen

                LiveChart ChartAusgabe = new LiveChart();
                ChartAusgabe.erfassen("0", "0", tempForm, true, true);
                iTickAktuell = iTickAktuell + iTickInterval;
                tmrMesswerteTimer.Stop();
                //                tmrMesswerteTimer.Enabled = false;
                //                tmrMesswerteTimer.Dispose();
                tmrMesswerteTimer.Close();
            }
            else
            {
                //  Console.WriteLine("teste" + iTickInterval + ":" + ende);
                // Restarts the timer and increments the counter.
                SendToCOM("M");

                iTickAktuell = iTickAktuell + iTickInterval;
            }

        }

        /// <summary>
        /// Sendet einen String an geöffneten com port
        /// </summary>
        /// <param name="Caption">String</param>

        public bool SendToCOM(String Caption, bool bCheckStatus = false)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("COM nicht verbunden");
                return false;

            }
            if (bereit == true)
            {
                tempForm.stlLog.Add("Gesendet : " + Caption + "    " + System.DateTime.Now.ToString());
                Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : " + Caption, tempForm);
                port.WriteLine(Caption);

                bereit = false;
                return true;
            }
            if (bCheckStatus)
            {
                Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : s", tempForm);
                AbfrageStatus();
            }
            return false;
        }
        public void COMDisconnect()
        {
            port.Close();
        }

        public void AbfrageStatus()
        {
            if (!port.IsOpen) return;
            Thread.Sleep(1000); //um zu verhindern dass das Gerät mit Abfragen zugespamt wird (führt sonst zu fehlern)
           // Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : s", tempForm);
            port.WriteLine("s");
        }

        public void Execute_Commands(int repeat, params string[] Commands)
        {
            for (int j = 0; j < repeat; j++)
            {
                for (int i = 0; i < Commands.Count(); i++)
                {
                    Boolean Lauf = true; //Pufferzeit mitschicken wenn der Befehl lange zum abarbeiten braucht und eine eventbehandlung stattfindet, wenn der Thread fertig ist
                    do
                    {
                        if (tempForm.Abbruch == true) return;
                        Lauf = SendToCOM(Commands[i], true);
                        Console.WriteLine("Line: " + Commands[i]);
                        System.Threading.Thread.Sleep(1000);

                    } while (Lauf == false);
                }
            }
            //tempForm.Invoke(new Action(() => { MessageBox.Show(tempForm, "Die Sequenz wurde abgearbeitet!"); }));
        }

        public void Execute_Ablauf()
        {
            // change_progressBar(-1, 0, progressBar1);
            for (int z = 0; z < tempForm.Durchläufe; z++)
            {
                for (int i = 0; i < tempForm.lstMaster.Count; i++) // warum hast du davor mit 1 angefangen und warum befindet sich die Methode überhaupt in der MainForm?
                {
                    Boolean Lauf = true;
                    do
                    {
                        if (tempForm.Abbruch == true) return;
                        Lauf = SendToCOM("X" + tempForm.lstMaster[i], true);
                        Console.WriteLine("Line: " + i + ";" + tempForm.lstMaster.Count + ";" + "X" + tempForm.lstMaster[i]);
                        tempForm.stlLog.Add("Line: " + i + ";" + tempForm.lstMaster.Count + ";" + "X" + tempForm.lstMaster[i]);
                        System.Threading.Thread.Sleep(1000);

                    } while (Lauf == false);
                }
                //change_progressBar(z, Durchläufe, progressBar1);
            }
            tempForm.stlLog.Add("Completed threadAblaufStart" + "    " + System.DateTime.Now.ToString());
        }


    }
}

