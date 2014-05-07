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



namespace PharMS_Steuerung
{
    public partial class Form1 : Form
    { // das ist ein test VS
        static Funktionen.COM Comschnitstelle;
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
        
        public Form1()
        {
            
           
           
           InitializeComponent();
           
     
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Speicher_TextChanged(object sender, EventArgs e)
        {
            // string Name = Speicher.SelectedText.ToString();
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
               else ablauf = ablauf +";"+ lines[i];

            }
 
            Console.WriteLine("Incoming Data:"+ "Y"+comboBox1.SelectedItem.ToString() + ablauf);
            
            Comschnitstelle.COMSender("Y"+comboBox1.SelectedItem.ToString()+ablauf);



        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Comschnitstelle = new Funktionen.COM(this);
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
                Funktionen.Exporting Save = new Funktionen.Exporting(DatenerfassungTab, sfd.FileName); // Here dataGridview1 is your grid view name 
            }              

       }

        public bool DatenerfassungTab_Hinzu(string Time, string Daten, string Daten2)
       {
           if (this.InvokeRequired) { 
           
           return (bool) this.Invoke((Func<string,string,string, bool>)DatenerfassungTab_Hinzu, Time, Daten , Daten2);
           
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
            {   change_Label("In Arbeit", label6);
                Comschnitstelle.COMSender("X"+comboBox2.SelectedItem.ToString());
                
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
   
        public bool change_Label (string Text, Label Textlabel){
            if (this.InvokeRequired)
            {

                return (bool)this.Invoke((Func<string, Label, bool>)change_Label, Text, Textlabel);

            }
            Textlabel.Text = Text;


            return true;
    }
 
        public bool change_progressBar(int aktuell,int Stepp,ProgressBar statusleist )
        {
            if (this.InvokeRequired)
            {

                return (bool)this.Invoke((Func<int,int, ProgressBar, bool>)change_progressBar,aktuell, Stepp, statusleist);

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
            Name = Masterablauf.SelectedItem.ToString();
            Thread thread1 = new Thread(new ThreadStart(Execute_Ablauf));
            thread1.Start();        
            
        }

        public void Execute_Ablauf()
        {
            List<String> newlines = new List<string>();


            CfgFile test = new CfgFile(Name);

            //  Console.WriteLine("Incoming Data:" + lines[0]);
            newlines = test.Ausgabe("Master\\" + Name);
            int count = newlines.Count;
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
                    
                    change_progressBar(z, Durchläufe, progressBar1);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> dirs = new List<string>(Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory + "Abläufe\\", "*.txt"));
            List<string> dirAblauf = new List<string>(Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory + "Abläufe\\Master\\", "*.txt"));


            AblaufListe.Items.Clear();
            //   AblaufListe.Items.Add("ROOT");
            foreach (var dir in dirs)
            {
                FileInfo x = new FileInfo(dir);

                AblaufListe.Items.Add(x.Name);

            }

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
            Comschnitstelle.COMSender("U"+numericZellspannung.Value);
            int n = Convert.ToInt32(numeric_Intervall.Value);
            ende = Convert.ToInt32(numeric_Messdauer.Value);
            ende = ende * 60 / n;
            if (i == 1) {
                
                Zeitsteuerung.Tick += new EventHandler(TimerEventProcessor);
            };
            i = i + 1;
            alarmCounter = 1;
            Zeitsteuerung.Interval = n * 1000;
            Zeitsteuerung.Start();
                


        }

        private static void TimerEventProcessor(Object myObject,EventArgs myEventArgs)
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
                Funktionen.Datenerfassen test = new Funktionen.Datenerfassen("---------,---------",Comschnitstelle.tempForm);
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

       
    }
}