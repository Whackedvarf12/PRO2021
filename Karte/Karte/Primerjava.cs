using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karte
{
    class Primerjava:IComparer<Karta>
    {
        public int Compare(Karta x, Karta Y)
        {
            if (x.Vrednost<Y.Vrednost)
            {
                return -1;
            }
            else if(x.Vrednost>Y.Vrednost)
            {
                return 1;
            }
            if (x.Barva<Y.Barva)
            {
                return -1;
            }
            else if (x.Barva>Y.Barva)
            {
                return 1;
            }
            return 0;
        }
    }
}
