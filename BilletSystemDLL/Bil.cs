using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Bil
    {
        public String NummberPlade { get; set; }

        public DateTime Dato { get; set; }

        public int Pris()
        {
            return 240;
        }

        public string KøreTøj()
        {
            return "Bil";
        }
    }
}
