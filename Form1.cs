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
    {
        Funktionen.COM Comschnitstelle;
        string ablauf;
        public bool Connection;
        public string Name;
        public int Durchläufe;
        public bool Abbruch;
        public Form1()
        {
                   

            List<string> dirs = new List<string>(Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory + "Abläufe\\", "*.txt"));
            List<string> dirAblauf = new List<string>(Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory + "Abläufe\\Master\\", "*.txt"));

            InitializeComponent();
            AblaufListe.Items.Clear();
            //    AblaufListe.Items.Add("ROOT");
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

            for (int i = 1; i >= count; i++)
            {

                ablauf = ";"+ablauf + lines[i];

            }

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

        public bool DatenerfassungTab_Hinzu(String Time, string Daten, string Daten2)
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
            {
                Comschnitstelle.COMSender("X"+comboBox2.SelectedItem.ToString());
                change_Label("In Arbeit", label6);
               // label6.Text = "In Arbeit";
                
            }
            else
            {
                MessageBox.Show("COM nicht Verbunden");
            }
        }

        private void NOTSTOPP_Click(object sender, EventArgs e)
        {
            Comschnitstelle.COMNotSender("14h(DC4)");

        }
        public bool change_Label (string Text, Label Textlabel){
            if (this.InvokeRequired)
            {

                return (bool)this.Invoke((Func<string, Label, bool>)change_Label, Text, Textlabel);

            }
            Textlabel.Text = Text;


            return true;
    }

        private void Stopp_Click(object sender, EventArgs e)
        {
            Comschnitstelle.COMSender("B");
        }


        private void AblaufStart_Click(object sender, EventArgs e)
        {
            Abbruch = true;
            Durchläufe = Convert.ToInt32(numericUpDown1.Value);
            Name = Masterablauf.SelectedItem.ToString();
            Thread thread1 = new Thread(new ThreadStart(Execute));
            thread1.Start();
           
            
        }

        public void Execute()
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
                    while (Comschnitstelle.COMAblaufSender("X" + newlines[i]) == false) {

                        if (Abbruch == true) { break; }
                        System.Threading.Thread.Sleep(1000); };
                }
            }
        }

        private void AblaufStopp_Click(object sender, EventArgs e)
        {
            Abbruch = true;
            Comschnitstelle.COMSender("B");
            
        }
    }
}