﻿/*Datenerfassung und Ausgabe in EXCEL*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PharMS_Steuerung.Funktionen
{
    class Exporting
    {
        public Exporting (DataGridView Data, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < Data.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(Data.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < Data.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < Data.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(Data.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();

        }  
        
    
    
    
    }
}
