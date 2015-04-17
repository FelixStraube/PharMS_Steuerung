using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Data.SQLite.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace PharMS_Steuerung.Funktionen
{
    public class SQLMain
    {
        public string sDBPath;
        public DataSet dsPharms;
        private SQLiteConnection conn;
        private SQLiteDataAdapter daMasterablauf, daSequenzen, daMesswerte, daSequenzenBefehle, daMesszyklus;
        private DataTable dtMasterablauf, dtSequenzen, dtMesswerte, dtSequenzenBefehle, dtMesszyklus;
        private SQLiteCommandBuilder cmdbMasterablauf, cmdbMesswerte, cmdbSequenzen, cmdbSequenzenBefehle, cmdbMesszyklus;
        private SQLiteCommand cmdMasterablauf, cmdMesswerte, cmdSequenzen, cmdSequenzenBefehle, cmdMesszyklus;

        public SQLMain(String sFileName)
        {
            if (File.Exists(sFileName))
            {
                conn = new SQLiteConnection("Data Source=" + sFileName);
            }
            else
            {
                SQLiteConnection.CreateFile(sFileName);
                conn = new SQLiteConnection("Data Source=" + sFileName);
                CreateTables();
            }
            sDBPath = sFileName;
            dsPharms = new DataSet();

            dtMasterablauf = new DataTable();
            dtMasterablauf.TableName = "Masterablauf";
            dtSequenzen = new DataTable();
            dtSequenzen.TableName = "Sequenzen";
            dtMesswerte = new DataTable();
            dtMesswerte.TableName = "Messwerte";
            dtSequenzenBefehle = new DataTable();
            dtSequenzenBefehle.TableName = "SequenzEdit";
            dtMesszyklus = new DataTable();
            dtMesszyklus.TableName = "Messzyklus";

            daMasterablauf = new SQLiteDataAdapter();
            daMesswerte = new SQLiteDataAdapter();
            daSequenzen = new SQLiteDataAdapter();
            daSequenzenBefehle = new SQLiteDataAdapter();
            daMesszyklus = new SQLiteDataAdapter();

            daMasterablauf.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daMesswerte.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daSequenzen.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daSequenzenBefehle.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daMesszyklus.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            cmdbMasterablauf = new SQLiteCommandBuilder(daMasterablauf);
            cmdbMesswerte = new SQLiteCommandBuilder(daMesswerte);
            cmdbSequenzen = new SQLiteCommandBuilder(daSequenzen);
            cmdbSequenzenBefehle = new SQLiteCommandBuilder(daSequenzenBefehle);
            cmdbMesszyklus = new SQLiteCommandBuilder(daMesszyklus);

            cmdSequenzenBefehle = new SQLiteCommand();
            cmdSequenzenBefehle.Connection = conn;
            cmdSequenzenBefehle.CommandText = "Select * From Sequenzen_Befehle";
            daSequenzenBefehle.SelectCommand = cmdSequenzenBefehle;
            daSequenzenBefehle.Fill(dtSequenzenBefehle);

            cmdMasterablauf = new SQLiteCommand();
            cmdMasterablauf.Connection = conn;
            cmdMasterablauf.CommandText = "Select * From Masterablauf";
            daMasterablauf.SelectCommand = cmdMasterablauf;
            daMasterablauf.Fill(dtMasterablauf);

            cmdMesswerte = new SQLiteCommand();
            cmdMesswerte.Connection = conn;
            cmdMesswerte.CommandText = "Select * From Messwerte";
            daMesswerte.SelectCommand = cmdMesswerte;
            daMesswerte.Fill(dtMesswerte);

            cmdSequenzen = new SQLiteCommand();
            cmdSequenzen.Connection = conn;
            cmdSequenzen.CommandText = "Select * From Sequenzen";
            daSequenzen.SelectCommand = cmdSequenzen;
            daSequenzen.Fill(dtSequenzen);

            cmdMesszyklus = new SQLiteCommand();
            cmdMesszyklus.Connection = conn;
            cmdMesszyklus.CommandText = "Select * From Messzyklus";
            daMesszyklus.SelectCommand = cmdMesszyklus;
            daMesszyklus.Fill(dtMesszyklus);
            dtMesszyklus.Columns["ID"].AutoIncrementSeed = 1;

            dsPharms.Tables.Add(dtSequenzen);
            dsPharms.Tables.Add(dtMesswerte);
            dsPharms.Tables.Add(dtMasterablauf);
            dsPharms.Tables.Add(dtSequenzenBefehle);
            dsPharms.Tables.Add(dtMesszyklus);
        }

        private void CreateTables()
        {
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Sequenzen ( " +
                "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                "Name VARCHAR(256) NOT NULL," +
                "Speicherplatz VARCHAR(2));";

            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Sequenzen_Befehle ( " +
               "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
               "Befehl VARCHAR(20) NOT NULL," +
               "Parameter VARCHAR(256)," +
               "S_ID INTEGER NOT NULL," +
               "Reihenfolge INTEGER NOT NULL," +
               "Vorlage BOOL);";

            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Masterablauf ( " +
               "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
               "Name VARCHAR(256) NOT NULL," +
               "S_ID INTEGER NOT NULL," +
               "Reihenfolge INTEGER NOT NULL," +
               "Speicherplatz VARCHAR(2)," +
               "Iterationsanzahl INTEGER" +
               "Reihenfolge_Master INTEGER);";

            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Messwerte ( " +
               "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
               "MZ_ID INTEGER NOT NULL," +
               "MW1 DOUBLE NOT NULL," +
               "MW2 DOUBLE NOT NULL," +
               "Datum DATETIME);";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Messzyklus ( " +
             "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
             "Name VARCHAR(256) NOT NULL," +
             "Datum DATETIME);";
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public List<String> GetMasterablauf()
        {
            List<String> Speicherplatz = new List<String>();
            DataTableReader dtr;
            dtr = dsPharms.Tables["Masterablauf"].CreateDataReader();

            while (dtr.Read())
            {
                if (dtr["Speicherplatz"].ToString() != " ")
                    Speicherplatz.Add(dtr["Speicherplatz"].ToString());
            }
            dtr.Close();
            return Speicherplatz;
        }

        public List<int> GetSequenzIDsFromMasterablauf(string Name)
        {
            List<int> IDs = new List<int>();
            DataTable dtt = new DataTable();            //Erstellt eine leere Hilfs-Tabelle
            DataTableReader dtr;
            dsPharms.Tables["Masterablauf"].DefaultView.RowFilter = "Name = '" + Name + "'";
            dsPharms.Tables["Masterablauf"].DefaultView.Sort = "Reihenfolge ASC";
            dtt = dsPharms.Tables["Masterablauf"].DefaultView.ToTable();         //Leere Hilfs-Tabelle wird gefüllt

            dtr = dtt.CreateDataReader();

            while (dtr.Read())
            {
                if (dtr["S_ID"].ToString() != " ")
                    IDs.Add(Convert.ToInt32(dtr["S_ID"]));
            }
            dtr.Close();
            return IDs;
        }

        public DataTable GetGroupedMasterablauf()
        {
            DataTable dt = new DataTable();

            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("Select Name,Reihenfolge_Master,Iterationsanzahl FROM Masterablauf Group By Name", conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();

            return dt;
        }


        public void UpdateMasterGrid2(string Name, int Reihenfolge, int Iteration)
        {
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Update Masterablauf " +
                "Set Name = \"" + Name + "\", " +
                "Reihenfolge_Master = " + Reihenfolge.ToString() + ", " +
                "Iterationsanzahl = " + Iteration.ToString() + " " +
                "WHERE Name = \"" + Name + "\";";

            int affectedRows = cmd.ExecuteNonQuery();

            if (affectedRows == 0)
            {
                cmd.CommandText = "Update Masterablauf " +
               "Set Name = \"" + Name + "\", " +
               "Reihenfolge_Master = " + Reihenfolge.ToString() + ", " +
               "Iterationsanzahl = " + Iteration.ToString() + " " +
               "WHERE Reihenfolge_Master = " + Reihenfolge.ToString() + ";";
            }
            affectedRows = cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public void InsertMasterGrid2(string Name, int Reihenfolge, int Iteration)
        {
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Masterablauf (Name, Reihenfolge_Master, Iterationsanzahl,S_ID,Reihenfolge) " +
                              "VALUES (\"" + Name + " \",\"" + Reihenfolge + "\",\"" + Iteration + "\",1,999)";

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void DeleteMasterGrid2(string Name)
        {
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Delete FROM Masterablauf where Name = '" + Name + "'";

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            daMasterablauf.Update(dsPharms, "Masterablauf");
        }


        public void ImportSequenz(string sFileName)
        {
            var TextFile = File.ReadAllLines(sFileName);
            string sOut;
            int ID;
            List<string> lstSequenz = new List<string>(TextFile);
            DataRow row;
            for (int i = 0; i < lstSequenz.Count(); i++)
            {
                if (i == 0)
                {
                    row = dsPharms.Tables["Sequenzen"].NewRow();
                    row["Name"] = lstSequenz[i];
                    row["ID"] = dsPharms.Tables["Sequenzen"].Rows.Count + 1;
                    dsPharms.Tables["Sequenzen"].Rows.Add(row);
                }
                else
                {
                    row = dsPharms.Tables["SequenzEdit"].NewRow();

                    if (lstSequenz[i] == "M")
                    {
                        row["Befehl"] = lstSequenz[i];
                        row["Parameter"] = "";
                        continue;
                    }
                    if (Sequenzeditor.dictSequenzBefehle.TryGetValue(lstSequenz[i].Substring(0, 2), out sOut))
                    {
                        row["Befehl"] = lstSequenz[i].Substring(0, 2);
                        row["Parameter"] = lstSequenz[i].Remove(0, 2);
                    }
                    else
                    {
                        if (Sequenzeditor.dictSequenzBefehle.TryGetValue(lstSequenz[i].Substring(0, 1), out sOut))
                        {
                            row["Befehl"] = lstSequenz[i].Substring(0, 1);
                            row["Parameter"] = lstSequenz[i].Remove(0, 1);
                        }

                    }
                    ID = Convert.ToInt32(dsPharms.Tables["Sequenzen"].Rows[dsPharms.Tables["Sequenzen"].Rows.Count - 1].ItemArray[0]);
                    row["S_ID"] = ID;
                    row["Reihenfolge"] = i;
                    dsPharms.Tables["SequenzEdit"].Rows.Add(row);

                }
            }


        }
        public List<int> GetAllSequenzID()
        {
            List<int> IDs = new List<int>();
            DataTableReader dtr;
            dtr = dsPharms.Tables["Sequenzen"].CreateDataReader();

            while (dtr.Read())
            {
                IDs.Add((int)dtr["ID"]);
            }
            dtr.Close();
            return IDs;
        }

        public List<int> GetAllSequenzIDWithMemory()
        {
            List<int> IDs = new List<int>();
            DataTableReader dtr;
            dsPharms.Tables["Sequenzen"].DefaultView.Sort = "Speicherplatz";
            dtr = dsPharms.Tables["Sequenzen"].CreateDataReader();

            while (dtr.Read())
            {
                if (dtr["Speicherplatz"].ToString() != " " && dtr["Speicherplatz"].ToString() != "")
                    IDs.Add(Convert.ToInt32(dtr["ID"]));
            }
            dtr.Close();
            return IDs;
        }

        public List<string> GetSequenzByIDAsList(int S_ID)
        {
            List<string> lstSequenz = new List<string>();

            var query = from a in dsPharms.Tables["Sequenzen"].AsEnumerable()
                        join b in dsPharms.Tables["SequenzEdit"].AsEnumerable()
                            on a.Field<Int64>("ID") equals
                                b.Field<Int64>("S_ID")
                        where b.Field<Int64>("S_ID") == S_ID
                        orderby b.Field<Int64>("Reihenfolge")
                        select new
                        {
                            S_ID = b.Field<Int64>("S_ID"),
                            Reihenfolge = b.Field<Int64>("Reihenfolge"),
                            Befehl = b.Field<string>("Befehl"),
                            Parameter = b.Field<string>("Parameter"),
                            Speicherplatz = a.Field<string>("Speicherplatz")
                        };

            foreach (var q in query)
            {
                lstSequenz.Add(q.Befehl + q.Parameter);
            }
            return lstSequenz;
        }
        public string GetSequenzByID(int S_ID)
        {
            string sSequenz = "";

            var query = from a in dsPharms.Tables["Sequenzen"].AsEnumerable()
                        join b in dsPharms.Tables["SequenzEdit"].AsEnumerable()
                            on a.Field<Int64>("ID") equals
                                b.Field<Int64>("S_ID")
                        where b.Field<Int64>("S_ID") == S_ID
                        orderby b.Field<Int64>("Reihenfolge")
                        select new
                        {
                            S_ID = b.Field<Int64>("S_ID"),
                            Reihenfolge = b.Field<Int64>("Reihenfolge"),
                            Befehl = b.Field<string>("Befehl"),
                            Parameter = b.Field<string>("Parameter"),
                            Speicherplatz = a.Field<string>("Speicherplatz")
                        };

            int i = 0;
            foreach (var q in query)
            {
                if (i == 0)
                    sSequenz = "Y" + q.Speicherplatz.ToString() + ";";

                if (query.Count() == i + 1) sSequenz = sSequenz + q.Befehl + q.Parameter;
                else sSequenz = sSequenz + q.Befehl + q.Parameter + ";";
                i++;
            }
            return sSequenz;
        }

        public string GetSequenzNameByID(int S_ID)
        {
            string sSequenzName = "";

            var query = from a in dsPharms.Tables["Sequenzen"].AsEnumerable()
                        where a.Field<Int64>("ID") == S_ID
                        select new
                        {
                            Name = a.Field<string>("Name"),

                        };

            foreach (var q in query)
            {
                sSequenzName = q.Name;
            }
            return sSequenzName;
        }

        public void DeleteSequenzEditByID(int ID)
        {
            DataRow[] foundRows;

            foundRows = dsPharms.Tables["SequenzEdit"].Select("S_ID = " + ID.ToString());

            foreach (DataRow Row in foundRows)
            {
                Row.Delete();
            }

        }

        public void DeleteMeasurementByID(int ID)
        {
            DataRow[] foundRows;

            foundRows = dsPharms.Tables["Messwerte"].Select("MZ_ID = " + ID.ToString());

            foreach (DataRow Row in foundRows)
            {
                Row.Delete();
            }

        }

        public string GetSequenzMemoryByID(int ID)
        {
            string sSequenz = "";

            var query = from a in dsPharms.Tables["Sequenzen"].AsEnumerable()

                        where a.Field<Int64>("ID") == ID
                        select new
                        {
                            Speicherplatz = a.Field<string>("Speicherplatz")
                        };

            foreach (var q in query)
            {
                sSequenz = (q.Speicherplatz == null) ? " " : q.Speicherplatz.ToString();
            }
            return sSequenz;
        }

        public void SetMeasurements(String MW1, String MW2, String MZ_ID)
        {
            DataRow row;
            row = dsPharms.Tables["Messwerte"].NewRow();
            row["MW1"] = Convert.ToDouble(MW1);
            row["MW2"] = Convert.ToDouble(MW2);
            row["MZ_ID"] = Convert.ToInt32(MZ_ID);
            row["Datum"] = DateTime.Now;
            dsPharms.Tables["Messwerte"].Rows.Add(row);
        }

        public string CreateZyklus()
        {
            DataRow row;
            row = dsPharms.Tables["Messzyklus"].NewRow();
            row["Name"] = "Zyklus " + (dsPharms.Tables["Messzyklus"].Rows.Count + 1).ToString();
            row["Datum"] = DateTime.Now;
            dsPharms.Tables["Messzyklus"].Rows.Add(row);

            return dsPharms.Tables["Messzyklus"].Rows[dsPharms.Tables["Messzyklus"].Rows.Count - 1].ItemArray[0].ToString();
        }

        public List<int> GetAllZyklusID()
        {
            List<int> IDs = new List<int>();
            DataTableReader dtr;
            dtr = dsPharms.Tables["Messzyklus"].CreateDataReader();

            while (dtr.Read())
            {
                IDs.Add(Convert.ToInt32(dtr["ID"]));
            }
            dtr.Close();
            return IDs;
        }

        public void Save()
        {
            daSequenzen.Update(dsPharms, "Sequenzen");
            daSequenzenBefehle.Update(dsPharms, "SequenzEdit");
            daMasterablauf.Update(dsPharms, "Masterablauf");
            daMesszyklus.Update(dsPharms, "Messzyklus");
            daMesswerte.Update(dsPharms, "Messwerte");

            // dtSequenzen.AcceptChanges();
        }
        public void SaveMeasurements()
        {
            daMesszyklus.Update(dsPharms, "Messzyklus");
            daMesswerte.Update(dsPharms, "Messwerte");

            // dtSequenzen.AcceptChanges();
        }
        public string NameMesszyklus(int ID)
        {
            string Name = "";


            var query = from a in dsPharms.Tables["Messzyklus"].AsEnumerable()

                        where a.Field<Int64>("ID") == ID
                        select new
                        {
                            Name = a.Field<string>("Name")
                        };

            foreach (var q in query)
            {
                Name = (q.Name == null) ? " " : q.Name.ToString();
            }


            return Name;
        }

    }
}

