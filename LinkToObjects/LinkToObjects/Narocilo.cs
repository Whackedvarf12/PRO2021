using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkToObjects
{
    class Narocilo
    {
        public int NarociloID { get; set; }
        public DateTime Datum{ get; set; }
        public String ImeKupca { get; set; }
        public Naslov NaslovRacuna { get; set; }
        public decimal Znesek { get; set; }
        public List<PodrobnostiNarocila> Elementi { get; set; }
        public Narocilo()
        {
            Elementi = new List<PodrobnostiNarocila>();
        }
    }
}
