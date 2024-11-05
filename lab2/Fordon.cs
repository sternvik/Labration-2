using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Fordon
    {
        public int FordonID { get; set; }
        public string Typ { get; set; }
        public int BatteriNivå { get; set; }
        public string Status { get; set; }
        public Station Station { get; set; }

        public Fordon(int id, string typ, int batteriNivå, string status, Station station)
        {
            FordonID = id;
            Typ = typ;
            BatteriNivå = batteriNivå;
            Status = status;
            Station = station;
            station.LäggTillFordon(this);
        }
    }
}
