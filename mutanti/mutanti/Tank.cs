using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    class Tank : Mutant
    {
        public int iq { get; set; }
        public int moc { get; set; }
        public override int nevarnost()
        {
            return stopnja * iq * moc;
        }
    }
}
