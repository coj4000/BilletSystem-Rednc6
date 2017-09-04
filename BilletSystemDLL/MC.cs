using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class MC : KøreTøj
    {

        public MC(string nummerPlade, DateTime dato, bool brobizz, BroType broNavn) 
            : base(nummerPlade, dato, brobizz, broNavn)
        {
        }

        public override int Pris()
        {
            int pris = 125;
            int rabatBB;

            if (BroNavn == KøreTøj.BroType.Øresund)
            {
                pris = 210;

                if (Brobizz == true)
                {
                    return 73;
                }
            }

            if ((Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday))
            {
                int rabatWD = (pris / 100) * 20;

                if (Brobizz == true)
                {
                    pris = pris - rabatWD;
                    rabatBB = (pris / 100) * 5;
                    return pris - rabatBB;
                }

                return pris - rabatWD;
            }
            if (Brobizz == true)
            {
                rabatBB = (pris / 100) * 5;
                return pris - rabatBB;
            }

            return pris;
        }

        public override string Type()
        {
            return "MC";
        }

    }
}
