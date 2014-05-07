using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PharMS_Steuerung
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           CfgFile oIni = new CfgFile("Config.ini");
           string Test = oIni.getValue("Alg", "Name", false);
           System.Console.Out.WriteLine("Das ist die IP " + Test);
            
            Application.Run(new Form1());
        }
    }
}
