using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace PharMS_Steuerung.Funktionen
{
    static class CSV_Export
    {

        public static void toCSV(DataGridView gridIn, string outputFile,SQLMain DBaktuel)
        {
            //CSV Trennzeichen
            string sTrenzeichen = ";";
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(outputFile);

                //write header rows to csv
                for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(sTrenzeichen);
                    }
                    if (i == 4) {
                        swOut.Write("Bezeichnung" + sTrenzeichen);
                    swOut.Write(gridIn.Columns[i].HeaderText);
                    }
                    else swOut.Write(gridIn.Columns[i].HeaderText);
                }

                swOut.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= gridIn.Rows.Count - 2; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = gridIn.Rows[j];

                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(sTrenzeichen);
                        }
                        if (!Convert.IsDBNull(dr.Cells[i]))  {
                        value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                       // value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        if (i == 4)
                        {
                            string Name;
                            Name = DBaktuel.NameMesszyklus(Convert.ToInt16(dr.Cells[i].Value.ToString()));
                            swOut.Write(Name + sTrenzeichen);
                        }
                        value = value.Replace(Environment.NewLine, " ");

                        swOut.Write(value);}
                    }
                }
                swOut.Close();
            }
        }
    }
}

