using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karte
{
    class Karta
    {
        public Vrednosti Vrednost { get; set; }
        public Barve Barva { get; set; }
        public String Ime
        {
            get{ return Vrednost + " " + Barva; }
        }
        public Karta(Vrednosti v, Barve b)
        {
            Vrednost = v;
            Barva = b;
        }
    }
}
