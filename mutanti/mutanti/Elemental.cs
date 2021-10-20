using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    class Elemental : Mutant
    {
        public int podrocje {get; set;}
        public override int nevarnost()
        {
            return stopnja * podrocje;
        }
    }
}
