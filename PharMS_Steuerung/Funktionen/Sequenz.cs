using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;


namespace PharMS_Steuerung.Funktionen
{
    public class Sequenz
    {
        public string sName, sPath , sDBName;
        public List<string> stlSequenz;
        public int iSpeicherplatz;


        public Sequenz()
        {
            /*sName = fiFile.Name;
            sPath = fiFile.DirectoryName;
            iniSequenz();*/
            stlSequenz = new List<string>();

        }


        private void iniSequenz()
        {
            CfgFile oCfgFile = new CfgFile(sName);
            stlSequenz = oCfgFile.Ausgabe(sName);
           // stlSequenz.RemoveAt(0);

        }


    }
}
