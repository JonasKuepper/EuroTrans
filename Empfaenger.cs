using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroTrans
{
    public class Empfaenger
    {
        private int id;
        private string name;
        private string vorname;
        private int alter;
        private double groesse;
        private double gewicht;
        private string blutgruppe;
    
        public Empfaenger(int id, string name, string vorname, int alter, double groesse, double gewicht, string blutgruppe)
        {
            this.id = id;
            this.name = name;
            this.vorname = vorname;
            this.alter = alter;
            this.groesse = groesse;
            this.gewicht = gewicht;
            this.blutgruppe = blutgruppe;
        }

        public int getId() => id;
        public string getName() => name;
        public string getVorname() => vorname;
        public int getAlter() => alter;
        public double getGroeße() => groesse;
        public double getGewicht() => gewicht;
        public string getBlutgruppe() => blutgruppe;
    }
}
