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
        public int iSpeicherplatz=-999;
        public bool bIsTemplate; 


        public Sequenz()
        {
           
            stlSequenz = new List<string>();

        }
        public Sequenz(FileInfo fiFile)
        {
            stlSequenz = new List<string>();
            sName = fiFile.Name;
            sPath = fiFile.DirectoryName;

            CfgFile oCfgFile = new CfgFile(sPath+"\\"+sName);
            stlSequenz = oCfgFile.Ausgabe(sPath+"\\"+sName);
            stlSequenz.RemoveAt(0);
          

        }


        private void iniSequenz()
        {
            CfgFile oCfgFile = new CfgFile(sName);
            stlSequenz = oCfgFile.Ausgabe(sName);         

        }


    }
}
