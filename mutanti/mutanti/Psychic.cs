using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    class Psychic : Mutant
    {
        public int iq { get; set; }
        public int uporaba { get; set; }
        public override int nevarnost()
        {
            return stopnja * iq * uporaba;
        }
    }
}
