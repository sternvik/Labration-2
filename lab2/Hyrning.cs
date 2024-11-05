using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Hyrning
    {
        public Fordon Fordon { get; private set; }
        public Station Station { get; set; }
        public DateTime StartTid { get; private set; }
        public DateTime Sluttid { get; private set; }
        public double Kostnad { get; private set; }
        public Användare Användare { get; private set; }

        public Hyrning(Fordon fordon, Användare användare, DateTime startTid)
        {
            Fordon = fordon;
            Användare = användare;
            StartTid = startTid;
            Kostnad = 0;
        }
    }
}
