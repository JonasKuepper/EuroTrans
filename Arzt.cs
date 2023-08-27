using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroTrans
{
    public class Arzt
    {
        private int m_id; // Mitarbeiter ID
        private string name;
        private string vorname;
        private string fachbereich;
        private string position;

        public Arzt(int m_id, string name, string vorname, string fachbereich, string position) 
        { 
            this.m_id = m_id;
            this.name = name;
            this.vorname = vorname;
            this.fachbereich = fachbereich;
            this.position = position;
        }

        public int getM_id() => m_id;
        public string getName() => name;
        public string getVorname() => vorname;
        public string getFachbereich() => fachbereich;
        public string getPosition() => position;
    }
}
