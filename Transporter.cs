using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace EuroTrans
{
    public class Transporter
    {
        private int id;
        private string name;
        private List<Herz> HIT = new List<Herz>(); // Herzen im Transporter
        private string zielkrankenhaus;
        private string aktuellePosition;


        public Transporter(int id, string name, string zielkrankenhaus) 
        { 
            this.id = id;
            this.name = name;
            this.zielkrankenhaus = zielkrankenhaus;
        }

        public int getId() => id;
        public string getName() => name;
        public string getZielkrankenhaus() => zielkrankenhaus;

        public string getAktuellePosition()
        {
            aktuellePosition = "Herseler Str. 1, 53117 Bonn";
            return aktuellePosition;
        }

        public void addHerz(Herz herz)
        {
            HIT.Add(herz);
        }

        public void printListe()
        {
            foreach (Herz herz in HIT)
            {
                Console.WriteLine(herz.AllData());
            }
        }

    }
}
