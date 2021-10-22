using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompleksna
{
    class Komp
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public override string ToString()
        {
            return Re + " + i*" + Im;
        }
        public static Komp operator +(Komp a, Komp b){
            Komp c = new Komp();
            c.Re = a.Re+ b.Re;
            c.Im = a.Im + b.Im;
            return c;
        }
        public static Komp operator -(Komp a, Komp b)
        {
            Komp c = new Komp();
            c.Re = a.Re - b.Re;
            c.Im = a.Im - b.Im;
            return c;
        }
        public static Komp operator *(Komp a, Komp b)
        {
            Komp c = new Komp();
            c.Re = a.Re * b.Re - a.Im * b.Im;
            c.Im = a.Re * b.Im + a.Im*b.Re;
            return c;
        }
    }
}
