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
        private SQLiteDataAdapter daMasterablauf, daSequenzen, daMesswerte, daSequenzenBefehle;
        private DataTable dtMasterablauf, dtSequenzen, dtMesswerte, dtSequenzenBefehle;
        private SQLiteCommandBuilder cmdbMasterablauf, cmdbMesswerte, cmdbSequenzen, cmdbSequenzenBefehle;
        private SQLiteCommand cmdMasterablauf, cmdMesswerte, cmdSequenzen, cmdSequenzenBefehle;

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


            daMasterablauf = new SQLiteDataAdapter();
            daMesswerte = new SQLiteDataAdapter();
            daSequenzen = new SQLiteDataAdapter();
            daSequenzenBefehle = new SQLiteDataAdapter();

            daMasterablauf.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daMesswerte.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daSequenzen.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daSequenzenBefehle.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            cmdbMasterablauf = new SQLiteCommandBuilder(daMasterablauf);
            cmdbMesswerte = new SQLiteCommandBuilder(daMesswerte);
            cmdbSequenzen = new SQLiteCommandBuilder(daSequenzen);
            cmdbSequenzenBefehle = new SQLiteCommandBuilder(daSequenzenBefehle);

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

            dsPharms.Tables.Add(dtSequenzen);
            dsPharms.Tables.Add(dtMesswerte);
            dsPharms.Tables.Add(dtMasterablauf);
            dsPharms.Tables.Add(dtSequenzenBefehle);

        }

        private void CreateTables()
        {
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Sequenzen ( " +
                "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                "Name VARCHAR(100) NOT NULL," +
                "Speicherplatz VARCHAR(2));";

            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Sequenzen_Befehle ( " +
               "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
               "Befehl VARCHAR(20) NOT NULL," +
               "Parameter VARCHAR(20)," +
               "S_ID INTEGER NOT NULL," +
               "Reihenfolge INTEGER NOT NULL," +
               "Vorlage BOOL);";

            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Masterablauf ( " +
               "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
               "Name VARCHAR(100) NOT NULL," +
               "S_ID INTEGER NOT NULL," +
               "Reihenfolge INTEGER NOT NULL," +
               "Speicherplatz VARCHAR(2));";

            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Messwerte ( " +
               "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
               "MW1 DOUBLE NOT NULL," +
               "MW2 DOUBLE NOT NULL," +
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
                Speicherplatz.Add(dtr["Speicherplatz"].ToString());
            }
            dtr.Close();
            return Speicherplatz;
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
            dtr = dsPharms.Tables["Sequenzen"].CreateDataReader();

            while (dtr.Read())
            {
                if (dtr["Speicherplatz"].ToString() != "")
                    IDs.Add(Convert.ToInt32(dtr["ID"]));
            }
            dtr.Close();
            return IDs;
        }
        public string GetSequenzByID(int S_ID)
        {
            string sSequenz = "";

            var query = from a in dsPharms.Tables["Sequenzen"].AsEnumerable()
                        join b in dsPharms.Tables["SequenzEdit"].AsEnumerable()
                            on a.Field<Int64>("ID") equals
                                b.Field<Int64>("S_ID")
                        where b.Field<Int64>("S_ID") == S_ID
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
                sSequenz = sSequenz + q.Befehl + q.Parameter + ";";
                i++;
            }
            return sSequenz;
        }

        public void SetMeasurements(String MW1, String MW2)
        {
            DataRow row;
            row = dsPharms.Tables["Messwerte"].NewRow();
            row["MW1"] = Convert.ToDouble(MW1);
            row["MW2"] = Convert.ToDouble(MW2);
            dsPharms.Tables["Messwerte"].Rows.Add(row);
        }

        public void Save()
        {
            daSequenzen.Update(dsPharms, "Sequenzen");
            daSequenzenBefehle.Update(dsPharms, "SequenzEdit");
            daMasterablauf.Update(dsPharms, "Masterablauf");
            daMesswerte.Update(dsPharms, "Messwerte");
            // dtSequenzen.AcceptChanges();
        }
    }
}
