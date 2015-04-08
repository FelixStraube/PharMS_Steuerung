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
        public bool bereit = true;
        private Communicator oCommunicator;



        public COM(Communicator p_Communicator)
        {
            oCommunicator=p_Communicator;
            CfgFile Config = new CfgFile("Config.ini");
            string ComPort = Config.getValue("COM", "Port", false);            
            System.Console.Out.WriteLine("Das ist Com Port  " + ComPort);
            port = new SerialPort(ComPort, 9600, Parity.None, 8, StopBits.One);
            Console.WriteLine("Incoming Data:");
            
            if (!GlobalVar.IsTest)
            {
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                if (port.IsOpen) return;
                else { port.Open(); bereit = true; };
            }
        }

        private void port_DataReceived(object sender,
          SerialDataReceivedEventArgs e)
        {
            if (!port.IsOpen) return;

            Status = port.ReadLine();
            oCommunicator.port_DataReceived(Status);

        }      

        public bool SendToCOM(String Caption, bool bForce)
        {
            if (!GlobalVar.IsTest)
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
                        port.WriteLine(Caption);
                        bereit = false;
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return true; //wenn test dann gib einfach immer true zurück
        }
        public void COMDisconnect()
        {
            port.Close();
        }       

        public void NotStop()
        {
            if (!port.IsOpen) return;  
            port.WriteLine("x");   
            Thread.Sleep(1000);
            port.WriteLine("p1.0");
            Thread.Sleep(1000);         
            port.WriteLine("d0");
            Thread.Sleep(1000); 
            port.WriteLine("U000");
            Thread.Sleep(1000);        
            bereit = true;
            oCommunicator.Abbruch = true;
        }



      

       
    }
}

