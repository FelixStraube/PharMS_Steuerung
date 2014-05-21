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

namespace PharMS_Steuerung.Funktionen
{// [STAThread] 
    class COM
    {// Create the serial port with basic settings
        public string eingabe;
        private string[] empfangene_snr = new string[50];
        // public StreamWriter softw_vers_in_temptxt = new StreamWriter(@"C:\Bio\temp.txt")
        private SerialPort port;
        //= new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        public Form1 tempForm = new Form1();
        public bool bereit;
        public System.Windows.Forms.Timer tmrMesswerteTimer;
        /// <summary>
        /// Öffnet COM Port und aktiviert data Recieved
        /// </summary>
        /// static System.Windows.Forms.Timer Zeitsteuerung = new System.Windows.Forms.Timer();
        /// Timer 
        private int iTickInterval, iTickAktuell;
        static bool exitFlag = false;
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

            eingabe = port.ReadLine();
            //eingabe = port.ReadExisting();
            Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG(eingabe, tempForm);
            string steuerzeichen = eingabe.Substring(0, 1);

            switch (steuerzeichen)
            {
                case "M":
                    if (tempForm.radioButton2.Checked == true) { Funktionen.Datenerfassen Ausgabe_manuel = new Datenerfassen(eingabe, tempForm); }
                    if (tempForm.radioButton1.Checked == true)
                    {
                        if (tmrMesswerteTimer != null) { Funktionen.Datenerfassen Ausgabe_automatisch = new Datenerfassen(eingabe, tempForm); }

                        else
                        {
                            tmrMesswerteTimer = new System.Windows.Forms.Timer();
                            iTickInterval = Convert.ToInt32(tempForm.numeric_Intervall.Value);
                            tmrMesswerteTimer.Interval = iTickInterval * 1000;  //s zu ms
                            tmrMesswerteTimer.Tick += new EventHandler(Execute);
                            ende = Convert.ToInt32(tempForm.numeric_Messdauer.Value);
                            ende = ende * 60 / iTickInterval;
                            tmrMesswerteTimer.Start();
                        }

                    }

                    break;

                case "Z":
                    AbfrageStatus("s");
                    break;

                case "s":
                    switch (eingabe)
                    {
                        case "s00":
                        case "s20":
                            if (tempForm.label6.Text == "In Arbeit")
                            {
                                tempForm.change_Label("Bereit", tempForm.label6);
                            }

                            bereit = true;
                            break;
                        case "s10":

                            System.Threading.Thread.Sleep(5000);
                            AbfrageStatus("s");
                            break;

                        default: break;
                    }

                    break;


                default: break;
            }

            Console.WriteLine("Eingelesen von Com 3" + eingabe + "/" + steuerzeichen);
        }

        private void Execute(Object myObject, EventArgs myEventArgs)
        {
            if (iTickAktuell >= ende)
            {
                tmrMesswerteTimer.Stop();
                tmrMesswerteTimer.Enabled = false;
                tmrMesswerteTimer.Dispose();
            }
            else
            {
                Console.WriteLine("teste" + iTickInterval + ":" + ende);
                // Restarts the timer and increments the counter.
                COMSender("M");
                Funktionen.Datenerfassen test = new Funktionen.Datenerfassen("---------,---------", tempForm);
                iTickAktuell = iTickAktuell + iTickInterval;
            }

        }

        /// <summary>
        /// Sendet einen String an geöffneten com port
        /// </summary>
        /// <param name="Caption">String</param>
        public void COMSender(String Caption)
        {
            if (!port.IsOpen) return;

            Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : " + Caption, tempForm);
            port.WriteLine(Caption);

            bereit = false;

        }
        public bool COMAblaufSender(String Caption)
        {
            if (!port.IsOpen)
            {
                MessageBox.Show("COM nicht verbunden");
                return false;

            }
            if (bereit == true)
            {
                Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : " + Caption, tempForm);
                port.WriteLine(Caption);

                bereit = false;
                return true;
            }
            else
            {
                // Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : s", tempForm);
                System.Threading.Thread.Sleep(100);
                //port.WriteLine("s");
                return false;
            }
        }
        public void COMDisconnect()
        {
            port.Close();
        }
        public void COMNotSender(String Caption)
        {
            if (!port.IsOpen) return;
            Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : " + Caption, tempForm);
            port.WriteLine(Caption);


        }
        public void AbfrageStatus(String Caption)
        {
            if (!port.IsOpen) ;
            Funktionen.Consolen_LOG ausg = new Funktionen.Consolen_LOG("Gesendet : " + Caption, tempForm);
            port.WriteLine(Caption);

            ;

        }

    }
}

