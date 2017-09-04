using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public abstract class KøreTøj
    {
        public string NummerPlade { get; set; }
        public DateTime Dato { get; set; }
        public bool Brobizz { get; set; }
        public BroType BroNavn { get; set; }
        public enum BroType { Øresund, Storbæltsbroen }

        public KøreTøj(string nummerPlade, DateTime dato, bool brobizz, BroType broNavn)
        {
            this.NummerPlade = nummerPlade;
            this.Dato = dato;
            this.Brobizz = brobizz;
            this.BroNavn = broNavn;

        }

        public abstract int Pris();
        public abstract string Type();
        public string NummerPladeCheck(String nummerPladeNr)
        {
            if (nummerPladeNr.Length > 7)
            {
                throw new ArgumentException("Nummerpladen er for lang");
            }

            return nummerPladeNr;
        }
    }
}
