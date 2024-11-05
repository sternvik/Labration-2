using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Admin : Person
    {
        public Admin(string namn, int användarID, string lösenord, string roll)
        : base(namn, användarID, lösenord, roll) { }
    }
}
