using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBlyat
{
    //kupci
    class Class1
    {
        protected String ime;
        protected decimal stanje;

        public decimal Stanje { get => stanje; }
        public string Ime { get => ime; set => ime = value; }

        public void beleziPlacilo(decimal placilo)
        {
            stanje -= placilo;
        }
        public virtual void beleziKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1:
                    stanje += minute * 0.2m;
                    break;
                case 2:
                    stanje += minute * 0.03m;
                    break;
            }
        }
    }
}
