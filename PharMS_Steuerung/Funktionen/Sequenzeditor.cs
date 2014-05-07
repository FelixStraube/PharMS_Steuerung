﻿/*Ausgab der Daten in eine Tabelle
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;


namespace PharMS_Steuerung.Funktionen
{
   public  class Sequenzeditor
    {
        public Dictionary<string, string> dictSequenzBefehleWithOneChar;
        public Dictionary<string, string> dictSequenzBefehleWithTwoChar;
        public List<string> lstCommands;
      
        public Sequenzeditor()
        {
            dictSequenzBefehleWithOneChar =  new Dictionary<string, string>();
            dictSequenzBefehleWithTwoChar =  new Dictionary<string, string>();
            lstCommands = new List<string>();

            dictSequenzBefehleWithOneChar.Add("X", "Makro  starten mit Sequenznr. ");
            dictSequenzBefehleWithOneChar.Add("x", "Makro  abbrechen mit Sequenznr. ");
            dictSequenzBefehleWithOneChar.Add("W", "Wartezeit in Minuten und Sekunden festlegen");
            dictSequenzBefehleWithOneChar.Add("w", "Wartezeit in Minuten und Sekunden abfragen");
            dictSequenzBefehleWithOneChar.Add("v", "Multiportventil n mit Ventilposition m n,m");
            dictSequenzBefehleWithOneChar.Add("p", "Pumpe Messkreislauf n ein/aus  n,1/0");
            dictSequenzBefehleWithOneChar.Add("f", "Abfrage Füllstandssensor Abfall leer/voll");
            dictSequenzBefehleWithOneChar.Add("A", "Thermostat kalibrieren");
            dictSequenzBefehleWithOneChar.Add("a", "Temperaturabfrage thermische Abfallbehandlung");
            dictSequenzBefehleWithOneChar.Add("T", "Thermostattemperatur einstellen mit -  nn.n - Solltemperatur");
            dictSequenzBefehleWithOneChar.Add("t", "Thermostattemperatur abfragen");
            dictSequenzBefehleWithOneChar.Add("M", "Abfrage aktuelle Sensorstrom [nA]");
            dictSequenzBefehleWithOneChar.Add("G", "Einstellung Verstärkung, Gain 1, 2, 4  Standard ist 2");
            dictSequenzBefehleWithOneChar.Add("U", "Einstelllung der Potentiostatspannung [mV]");
            dictSequenzBefehleWithOneChar.Add("u", "Abfrage der Potentiostatspannung [mV]");
            dictSequenzBefehleWithOneChar.Add("y", "Potenziostat ein/aus");

            

            dictSequenzBefehleWithTwoChar.Add("DV", "Dosiererventil n = 1,2 Ventilpositionen  1- Richtung Wasserflasche, 2 – 8 Portventil");
            dictSequenzBefehleWithTwoChar.Add("DS", "Geschwindigkeit mit 1 - Vmax, 40 - Vmin");
            dictSequenzBefehleWithTwoChar.Add("DP", "Ansaugmenge (µl)");
            dictSequenzBefehleWithTwoChar.Add("DD", "Ausstossmenge (µl)");
            dictSequenzBefehleWithTwoChar.Add("DA", "Absolutposition (0…500)");     
            dictSequenzBefehleWithTwoChar.Add("dn", "Begasung  1-ein, 0-aus");
            dictSequenzBefehleWithTwoChar.Add("on", "Thermostat ein/aus");
            dictSequenzBefehleWithTwoChar.Add("dw", "Begasungsdosierer"); // TODO  Parameter fallen aus den Konzept, seperate Lösung notwendig

            /* dwOS2A48000IS20A0\n  Z\n    - Kommandostring für Begasungsdosierer
               dw -  Kommando zur Stringeingabe
               O – Ventil auf Ansaugöffnung (rechts)
              S2 – zweitschnellste Geschwindigkeit
              A48000 – Absolutpositionierung 48000 Schritte (Max.)
              I –Ventil auf Ausstoßöffnung (links)
              S20 – Geschwindigkeit 20 (40 Minimum)
              A0  - Absolutpositionierung auf 0*/

     

                   

            lstCommands.Add("X");
            lstCommands.Add("x");
            lstCommands.Add("W");
            lstCommands.Add("w");
            lstCommands.Add("v");
            lstCommands.Add("p");
            lstCommands.Add("f");
            lstCommands.Add("A");
            lstCommands.Add("a");
            lstCommands.Add("T");
            lstCommands.Add("t");
            lstCommands.Add("M");
            lstCommands.Add("G");
            lstCommands.Add("U");
            lstCommands.Add("u");
            lstCommands.Add("y");
            lstCommands.Add("DV");
            lstCommands.Add("DS");
            lstCommands.Add("DP");
            lstCommands.Add("DD");
            lstCommands.Add("DA");
            lstCommands.Add("dn");
            lstCommands.Add("on");             
                       
            
            //grid.DataSource = source;


        }


    }
}
