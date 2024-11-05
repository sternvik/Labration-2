using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        public string Namn { get; set; }
        public int AnvändarID { get; set; }
        public string Lösenord { get; set; }
        public string Roll { get; set; }

        public Person(string namn, int användarID, string lösenord, string roll)
        {
            this.Namn = namn;
            this.AnvändarID = användarID;
            this.Lösenord = lösenord;
            this.Roll = roll;
        }
    }
}
