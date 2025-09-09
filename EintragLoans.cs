using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans
{
    internal class EintragLoans
    {
        public string Vorname;
        public string Nachname;
        public decimal Betrag;
        public DateTime LeihDatum;

        public EintragLoans(string vorname, string nachname, decimal betrag, DateTime leihDatum)
        { 
            Vorname = vorname;
            Nachname = nachname;    
            Betrag = betrag;
            LeihDatum = leihDatum;
        }
    }
}
