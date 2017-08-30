using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class MC
    {
        public String NummerPlace { get; set; }
        public DateTime Dato { get; set; }

        public int Pris()
        {
            return 125;
        }

        public string KøreTøj()
        {
            return "MC";
        }
    }
}
