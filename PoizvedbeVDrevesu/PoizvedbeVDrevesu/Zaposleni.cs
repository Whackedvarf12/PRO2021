using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoizvedbeVDrevesu
{
    class Zaposleni:IComparable<Zaposleni>
    {
        public int Id { get; set; }
        public String Ime { get; set; }
        public String Priimek { get; set; }
        public String Oddelek { get; set; }

        public int CompareTo(Zaposleni other)
        {
            if (this.Id < other.Id)
            {
                return -1;
            }
            if (this.Id>other.Id)
            {
                return 1;
            }
            return 0;
        }
        public override string ToString()
        {
            return Id + " " + Ime + " " + Priimek + " " + Oddelek;
        }
    }
}
