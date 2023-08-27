using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroTrans
{
    public class Operation
    {
        private Transporter transporter;
        private Empfaenger empfaenger;
        private Arzt arzt;
        private int operationssaal;
        private DateTime termin;

        public Operation(Transporter transporter, Empfaenger empfaenger, Arzt arzt, int operationssaal, DateTime termin) 
        { 
            this.transporter = transporter;
            this.empfaenger = empfaenger;
            this.arzt = arzt;
            this.operationssaal = operationssaal;
            this.termin = termin;
        }

        public Transporter getTransporter() => transporter;
        public Empfaenger getEmpfaenger() => empfaenger;
        public Arzt getArzt() => arzt;
        public int getOperationssaal() => operationssaal;
        public DateTime getTermination() => termin;

        public void OperationBeginnen()
        {

        }
    }
}
