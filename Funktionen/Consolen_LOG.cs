using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace PharMS_Steuerung.Funktionen
{
    class Consolen_LOG
    {

        private Form1 tempForm = new Form1();
        public Consolen_LOG(Form1 Ausgabefenster)
        {
            tempForm = Ausgabefenster;
        }
        public bool AddLog(String Übergabe)
        {
            if (tempForm.InvokeRequired)
            {
                return (bool)tempForm.Invoke((Func<string, bool>)AddLog, Übergabe);
            }
            tempForm.Console_Ausgabe.AppendText(Übergabe + Environment.NewLine);
            return true;
        }

        public bool SetLabelForMaster(String Übergabe)
        {

            if (tempForm.InvokeRequired)
            {
                return (bool)tempForm.Invoke((Func<string, bool>)SetLabelForMaster, Übergabe);
            }
            tempForm.lblMaster.Text = Übergabe;
            return true;
        }

        public bool SetLabelForSequenz(String Übergabe)
        {
            if (tempForm.InvokeRequired)
            {
                return (bool)tempForm.Invoke((Func<string, bool>)SetLabelForSequenz, Übergabe);
            }
            tempForm.lblSequenz.Text = Übergabe;
            return true;
        }

        public String GetLog()
        {
            string r = tempForm.Console_Ausgabe.Text;

            if (tempForm.InvokeRequired)
            {
                return (string)tempForm.Invoke((Func<string>)GetLog);
            }

            tempForm.Console_Ausgabe.Clear();
            return r;
        }
    }
}
