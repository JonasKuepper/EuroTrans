using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroTrans
{
    public class Spender
    {
        private int id;
        private string name;
        private string vorname;
        private int alter;
        private double groesse;
        private double gewicht;
        private string blutgruppe;
        private DateTime todeszeitpunkt;
    
        public Spender(int id, string name, string vorname, int alter, double groesse, double gewicht, string blutgruppe, DateTime todeszeitpunkt)
        {
            this.id = id;
            this.name = name;
            this.vorname = vorname;
            this.alter = alter;
            this.groesse = groesse;
            this.gewicht = gewicht;
            this.blutgruppe = blutgruppe;
            this.todeszeitpunkt = todeszeitpunkt;
        }

        public int getId() => id;
        public string getName() => name;
        public string getVorname() => vorname;
        public int getAlter() => alter;
        public double getGroeße() => groesse;
        public double getGewicht() => gewicht;
        public string getBlutgruppe() => blutgruppe;
        public DateTime getTodeszeitpunkt() => todeszeitpunkt;
    }
}
