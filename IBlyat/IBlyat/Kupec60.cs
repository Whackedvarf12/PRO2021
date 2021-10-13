using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBlyat
{
    class Kupec60:Class1
    {
        private int visjaTarifaPorabljeno;
        public new void beleziKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1:
                    stanje += minute * 0.2m;
                    break;
                case 2:
                    int vMinute;
                    int nMinute;
                    int isvMinute=(visjaTarifaPorabljeno<60)?60-visjaTarifaPorabljeno:0;
                    if (minute> isvMinute)
                    {
                        vMinute = isvMinute;
                        nMinute = minute - vMinute;
                    }
                    else
                    {
                        vMinute = minute;
                        nMinute = 0;
                    }
                    stanje = vMinute * 0.05m + nMinute * 0.01m;
                    visjaTarifaPorabljeno += vMinute;
                    break;
            }
        }
    }
}
