using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroTrans
{
    public class Herz
    {
        private Spender spender;
        private int puls;
        private string blutdruck;
        private int alter;
        private bool fettamherz; // Fett am Herz
        private bool herzerkrankung;
        private int zustand; // Wird in drei Stufen unterteilt

        public Herz(Spender spender, int puls, string blutdruck, int alter, bool FettamHerz, bool herzerkrankung)
        {
            this.spender = spender;
            this.puls = puls;
            this.blutdruck = blutdruck;
            this.alter = alter;
            this.fettamherz = FettamHerz;
            this.herzerkrankung = herzerkrankung;

            setZustand(FettamHerz, herzerkrankung);
            
        }

        // Gebe Werte aus
        public Spender getSpender() => spender;
        public int getPuls() => puls;
        public string getBlutdruck() => blutdruck;
        public int getAlter() => alter;
        public bool isFAH() => fettamherz;
        public bool isHerzerkrankt() => herzerkrankung;
        public int getZustand() => zustand;

        // Funktion zum überprüfen & festlegen des Zustands
        public void setZustand(bool faH, bool herzerkrankung)
        {
            // zustand = 0 --> nicht transplantationsfähig
            // zustand = 1 --> schlechter Zustand
            // zustand = 2 --> mittelmäßiger Zustand
            // zustand = 3 --> sehr guter Zustand
            zustand = 3;

            // Festellung von Fett am Herz
            if (faH == true)
            {
                zustand--;
            }
            
            // Festellung von Herzerkrankung
            if (herzerkrankung == true)
            {
                zustand--;
            }

            // Das Herz sollte normalerweise weniger als 4 bis 6 Stunden entnommen sein
            if (vergangeneStunden(spender.getTodeszeitpunkt()) > 6)
            {
                zustand = 0;
            }

            if (vergangeneStunden(spender.getTodeszeitpunkt()) > 4)
            {
                zustand = 1;
            }
        }

        public int vergangeneStunden(DateTime todeszeitpunkt)
        {
            TimeSpan differenz = DateTime.Now - todeszeitpunkt;
            int vergangeneStunden = (int)differenz.TotalHours;
            return vergangeneStunden;
        }

        public string AllData()
        {
            string all = "SID: " + spender.getId() + " P: " + puls + " BD: " + blutdruck + " A: " + alter + " FaH: " + fettamherz + " HE: " + herzerkrankung + " ZST: " + zustand;
            return all;
        }
    }
}
