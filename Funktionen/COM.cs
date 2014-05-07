using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;

namespace PharMS_Steuerung.Funktionen
{// [STAThread] 
    class COM
    {// Create the serial port with basic settings
        public string eingabe;
        private string[] empfangene_snr = new string[50];
        // public StreamWriter softw_vers_in_temptxt = new StreamWriter(@"C:\Bio\temp.txt")
        private SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        private Form1 tempForm = new Form1();
        public bool bereit;    
        /// <summary>
        /// Öffnet COM Port und aktiviert data Recieved
        /// </summary>
        
        public COM(Form1 Ausgabefenster)
        {
            tempForm = Ausgabefenster;
        CfgFile Config = new CfgFile("Config.ini");
         string Port = Config.getValue("COM", "Port", false);
         System.Console.Out.WriteLine("Das ist die IP "+Port);
         //port = new SerialPort("COM1",9600, Parity.None, 8, StopBits.One);
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
           string steuerzeichen = eingabe.Substring(0, 1);
            Console.WriteLine("Eingelesen von Com 1" + eingabe +"/" +steuerzeichen);
            if (steuerzeichen == "C")
            {
                Funktionen.Datenerfassen Ausgabe = new Datenerfassen(eingabe, tempForm);
                //tempForm.DatenerfassungTab_Hinzu("test", "hallo");
            }
            //Funktionen.Datenerfassen test = new Funktionen.Datenerfassen(eingabe, tempForm);
            if (steuerzeichen == "Z")
            {
                if (tempForm.label6.Text == "In Arbeit") 
                {
                    tempForm.change_Label("Bereit", tempForm.label6); 
                }
              
                bereit = true;
            }          
            
            


        }

        /// <summary>
        /// Sendet einen String an geöffneten com port
        /// </summary>
        /// <param name="Caption">String</param>
        public void COMSender(String Caption)
        {
            if (!port.IsOpen) return;
            
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
                port.WriteLine(Caption);

                bereit = false;
                return true;
            }
            else { return false; }
        }
        public void COMDisconnect()
        {
            port.Close();
        }
        public void COMNotSender(String Caption)
        {
            if (!port.IsOpen) return;
           
                port.WriteLine(Caption);

             
            }
        }
    }

