using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Narocilo> nar= setupNarocila();
            var x1 = from n in nar select n;
            foreach(var y in x1)
            {
                Console.WriteLine(y.NarociloID);
            }
            Console.ReadLine();
            var x2 = from n in nar
                     from n1 in n.Elementi
                     select n1;
            foreach (var y in x2)
            {
                Console.WriteLine(y.ElementID);
            }
            Console.ReadLine();
        }
        public static List<Narocilo> setupNarocila()
        {
            List<Narocilo> NarociloList = new List<Narocilo>();
            Narocilo o1 = new Narocilo();
            o1.Datum = DateTime.Parse("12.7.2010");
            o1.NarociloID = 9009;
            PodrobnostiNarocila oi1 = new PodrobnostiNarocila();
            oi1.ElementID = 123;
            oi1.ImeIzdelka = "Mars";
            oi1.Kolicina = 2;
            o1.Elementi.Add(oi1);
            PodrobnostiNarocila oi2 = new PodrobnostiNarocila();
            oi2.ElementID = 124;
            oi2.ImeIzdelka = "Kraš";
            oi2.Kolicina = 3;
            o1.Elementi.Add(oi2);
            Narocilo o2 = new Narocilo();
            o2.Datum = DateTime.Parse("12.1.2011");
            o2.NarociloID = 9010;
            PodrobnostiNarocila oi3 = new PodrobnostiNarocila();
            oi3.ElementID = 125;
            oi3.ImeIzdelka = "Mars";
            oi3.Kolicina = 1;
            o2.Elementi.Add(oi3);
            PodrobnostiNarocila oi4 = new PodrobnostiNarocila();
            oi4.ElementID = 126;
            oi4.ImeIzdelka = "Extreme";
            oi4.Kolicina = 5;
            o2.Elementi.Add(oi4);
            PodrobnostiNarocila oi5 = new PodrobnostiNarocila();
            oi5.ElementID = 127;
            oi5.ImeIzdelka = "Bazooka";
            oi5.Kolicina = 1;
            o2.Elementi.Add(oi5);
            PodrobnostiNarocila oi6 = new PodrobnostiNarocila();
            oi6.ElementID = 128;
            oi6.ImeIzdelka = "Sadje";
            oi6.Kolicina = 6;
            o2.Elementi.Add(oi6);
            NarociloList.Add(o1);
            NarociloList.Add(o2);

            return NarociloList;

        }
    }
}
