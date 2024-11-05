using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Användare : Person
    {
        public string BetalningsMetod { get; set; }
        public string KortNummer { get; set; }
        public List<string> Hyreshistorik { get; set; }

        public Användare(string namn, int användarID, string lösenord, string roll)
        : base(namn, användarID, lösenord, roll)
        {
            Hyreshistorik = new List<string>();
        }
    }
}
