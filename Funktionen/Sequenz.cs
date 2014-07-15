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
        public string sName, sPath, sDBName;
        public List<string> stlSequenz;
        public int iSpeicherplatz = -999;
        public bool bIsTemplate;
        public int ObjectKey;


        public Sequenz()
        {

            stlSequenz = new List<string>();

        }
        public Sequenz(FileInfo fiFile)
        {
            stlSequenz = new List<string>();
            sName = fiFile.Name;
            sPath = fiFile.DirectoryName;

            CfgFile oCfgFile = new CfgFile(sPath + "\\" + sName);
            stlSequenz = oCfgFile.Ausgabe(sPath + "\\" + sName);
            stlSequenz.RemoveAt(0);


        }


        private void iniSequenz()
        {
            CfgFile oCfgFile = new CfgFile(sName);
            stlSequenz = oCfgFile.Ausgabe(sName);

        }


        public static string ElektrodenTest()
        {
            List<String> lstSequenz = new List<string>();
            lstSequenz.Add("Y20;");
            lstSequenz.Add("DV2;");
            lstSequenz.Add("DS2;");
            lstSequenz.Add("v2,2;");
            lstSequenz.Add("DP1000;");
            lstSequenz.Add("v2,5;");
            lstSequenz.Add("v1,8;");
            lstSequenz.Add("DA0;");
            lstSequenz.Add("v2,3;");
            lstSequenz.Add("DP1000;");
            lstSequenz.Add("v2,5;");
            lstSequenz.Add("v1,8;");
            lstSequenz.Add("DA0;");
            lstSequenz.Add("v2,2;");
            lstSequenz.Add("DP750;");
            lstSequenz.Add("v2,5;");
            lstSequenz.Add("v1,1;");
            lstSequenz.Add("DA0;");
            lstSequenz.Add("v2,3;");
            lstSequenz.Add("DP750;");
            lstSequenz.Add("v2,5;");
            lstSequenz.Add("v1,1;");
            lstSequenz.Add("DA0;");
            lstSequenz.Add("p1,1;");
            lstSequenz.Add("U300;");
            lstSequenz.Add("W2,0;");
            lstSequenz.Add("M;");
            lstSequenz.Add("W5,10;");
            lstSequenz.Add("p1,0;");
            lstSequenz.Add("U000;");
            lstSequenz.Add("DV2;");
            lstSequenz.Add("DS4;");
            lstSequenz.Add("v1,1;");
            lstSequenz.Add("v2,5;");
            lstSequenz.Add("U000;");
            lstSequenz.Add("DP2500;");
            lstSequenz.Add("p1,1;");
            lstSequenz.Add("v1,8;");
            lstSequenz.Add("DD2500;");
            lstSequenz.Add("W0,30;");
            lstSequenz.Add("DV1;");
            lstSequenz.Add("DP2000;");
            lstSequenz.Add("DV2;");
            lstSequenz.Add("v1,1;");
            lstSequenz.Add("DA0;");
            lstSequenz.Add("DV1;");
            lstSequenz.Add("DP1500;");
            lstSequenz.Add("DV2;");
            lstSequenz.Add("DA0;");
            lstSequenz.Add("W1,0;");
            lstSequenz.Add("p1,0;");
            lstSequenz.Add("DP2500;");
            lstSequenz.Add("v1,8;");
            lstSequenz.Add("DA0;");
            lstSequenz.Add("v1,1;");
            lstSequenz.Add("DP2500;");
            lstSequenz.Add("v1,8;");
            lstSequenz.Add("DA0");

            string concat = String.Join(String.Empty, lstSequenz.ToArray());
            return concat;



        }
        public static string LeitungenSpuelen(bool overV1)
        {

            List<String> lstSequenz2 = new List<string>();
            List<String> lstSequenz1 = new List<string>();

            #region Liste
            //   Gerätesystem über V2 desinfizieren und spülen
            lstSequenz2.Add("Y19;");
            lstSequenz2.Add("DV1;");
            lstSequenz2.Add("DS2;");
            lstSequenz2.Add("DP2500;");
            lstSequenz2.Add("DV2;");
            lstSequenz2.Add("v2,7;");
            lstSequenz2.Add("DS12;");
            lstSequenz2.Add("DA0;");
            lstSequenz2.Add("DV1;");
            lstSequenz2.Add("DS2;");
            lstSequenz2.Add("DP2500;");
            lstSequenz2.Add("DV2;");
            lstSequenz2.Add("v2,8;");
            lstSequenz2.Add("DS12;");
            lstSequenz2.Add("DA0;");
            lstSequenz2.Add("DV1;");
            lstSequenz2.Add("DS2;");
            lstSequenz2.Add("DP2500;");
            lstSequenz2.Add("DV2;");
            lstSequenz2.Add("v2,1;");
            lstSequenz2.Add("DS12;");
            lstSequenz2.Add("DA0;");
            lstSequenz2.Add("DV1;");
            lstSequenz2.Add("DS2;");
            lstSequenz2.Add("DP2500;");
            lstSequenz2.Add("DV2;");
            lstSequenz2.Add("v2,2;");
            lstSequenz2.Add("DS12;");
            lstSequenz2.Add("DA0;");
            lstSequenz2.Add("DV1;");
            lstSequenz2.Add("DS2;");
            lstSequenz2.Add("DP2500;");
            lstSequenz2.Add("DV2;");
            lstSequenz2.Add("v2,3;");
            lstSequenz2.Add("DS12;");
            lstSequenz2.Add("DA0;");
            lstSequenz2.Add("DV1;");
            lstSequenz2.Add("DS2;");
            lstSequenz2.Add("DP2500;");
            lstSequenz2.Add("DV2;");
            lstSequenz2.Add("v2,6;");
            lstSequenz2.Add("DS12;");
            lstSequenz2.Add("DA0");

            //Gerätesystem über V1 desinfizieren und spülen
            lstSequenz1.Add("Y18;");
            lstSequenz1.Add("DV1;");
            lstSequenz1.Add("DS2;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("DV2;");
            lstSequenz1.Add("v2,5;");
            lstSequenz1.Add("v1,8;");
            lstSequenz1.Add("DA0;");
            lstSequenz1.Add("DV1;");
            lstSequenz1.Add("DS2;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("DV2;");
            lstSequenz1.Add("DS12;");
            lstSequenz1.Add("v1,5;");
            lstSequenz1.Add("DA0;");
            lstSequenz1.Add("DV1;");
            lstSequenz1.Add("DS2;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("DV2;");
            lstSequenz1.Add("DS12;");
            lstSequenz1.Add("v1,4;");
            lstSequenz1.Add("DA0;");
            lstSequenz1.Add("DV1;");
            lstSequenz1.Add("DS2;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("DV2;");
            lstSequenz1.Add("DS12;");
            lstSequenz1.Add("v1,3;");
            lstSequenz1.Add("DA0;");
            lstSequenz1.Add("DV1;");
            lstSequenz1.Add("DS2;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("DV2;");
            lstSequenz1.Add("DS12;");
            lstSequenz1.Add("v1,2;");
            lstSequenz1.Add("DA0;");
            lstSequenz1.Add("DV1;");
            lstSequenz1.Add("DS2;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("DV2;");
            lstSequenz1.Add("DS12;");
            lstSequenz1.Add("v1,1;");
            lstSequenz1.Add("DA0;");
            lstSequenz1.Add("p1,1;");
            lstSequenz1.Add("DV2;");
            lstSequenz1.Add("DS2;");
            lstSequenz1.Add("v2,5;");
            lstSequenz1.Add("v1,5;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("v1,8;");
            lstSequenz1.Add("DAO;");
            lstSequenz1.Add("v1,4;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("v1,8;");
            lstSequenz1.Add("DAO;");
            lstSequenz1.Add("v1,3;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("v1,8;");
            lstSequenz1.Add("DAO;");
            lstSequenz1.Add("v1,2;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("v1,8;");
            lstSequenz1.Add("DAO;");
            lstSequenz1.Add("v1,1;");
            lstSequenz1.Add("DP2500;");
            lstSequenz1.Add("v1,8;");
            lstSequenz1.Add("DA0;");
            lstSequenz1.Add("p1,0;");
            lstSequenz1.Add("v1,1;");
            lstSequenz1.Add("DP500;");
            lstSequenz1.Add("v1,8;");
            lstSequenz1.Add("DAO");

            #endregion

            string concat1 = String.Join(String.Empty, lstSequenz1.ToArray());
            string concat2 = String.Join(String.Empty, lstSequenz2.ToArray());
            if (overV1) return concat1;
            else return concat2;
        }

    }
}
