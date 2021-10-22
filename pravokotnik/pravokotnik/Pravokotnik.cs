using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravokotnik
{
    class Pravokotnik
    {
        private double sirina;
        private double visina;
        public Pravokotnik()
        {
            this.sirina = 0;
            this.visina = 0;
        }
        public Pravokotnik(double s, double v)
        {
            this.sirina = s;
            this.visina = v;
        }

        public double Sirina { get => sirina; set => sirina = value; }
        public double Visina { get => visina; set => visina = value; }
        public double Ploscina { get => sirina*visina; }

        public static bool operator ==(Pravokotnik b, Pravokotnik c)
        {
                return (b.Ploscina == c.Ploscina);
        }
        public static bool operator !=(Pravokotnik b, Pravokotnik c)
        {
                return (b.Ploscina != c.Ploscina);
        }
        public static bool operator >(Pravokotnik b, Pravokotnik c)
        {
            return (b.Ploscina > c.Ploscina);
        }
        public static bool operator <(Pravokotnik b, Pravokotnik c)
        {
            return (b.Ploscina < c.Ploscina);
        }
        public static bool operator >=(Pravokotnik b, Pravokotnik c)
        {
            return (b.Ploscina >= c.Ploscina);
        }
            public static bool operator <=(Pravokotnik b, Pravokotnik c)
        {
            return (b.Ploscina <= c.Ploscina);
        }
        public override string ToString()
        {
            return "Visina= "+visina+", Sirina= "+sirina;
        }
    }
}
