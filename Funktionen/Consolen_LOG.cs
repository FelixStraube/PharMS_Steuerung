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

namespace PharMS_Steuerung.Funktionen
{ 
   class Consolen_LOG
    {

       private Form1 tempForm = new Form1();
       public Consolen_LOG(string Eingabe, Form1 Ausgabefenster)
       {
           tempForm = Ausgabefenster;
           Ausgab_Extern(Eingabe);
          
           
       }
       public bool Ausgab_Extern(String Übergabe) {
           if (tempForm.InvokeRequired)
           {

               return (bool)tempForm.Invoke((Func<string, bool>)Ausgab_Extern, Übergabe);

           }
           
           
           tempForm.Console_Ausgabe.AppendText(Übergabe+Environment.NewLine);
           return true;
       }
    }
}
