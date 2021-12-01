using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            var kupci = new[]{
                new {KupecID=1,Ime="Janez",Priimek="Kranjski",Podjetje="Kolo"},
                new {KupecID=2,Ime="Miha",Priimek="Polanc",Podjetje="Djak"},
                new {KupecID=3,Ime="Gašper",Priimek="Rupnik",Podjetje="Fitnes"},
                new {KupecID=4,Ime="Martin",Priimek="Bolčina",Podjetje="Kolo"},
                new {KupecID=5,Ime="Alenka",Priimek="Puncer",Podjetje="Kolo"},
                new {KupecID=6,Ime="Mojca",Priimek="Širok",Podjetje="Djak"},
                new {KupecID=7,Ime="Peter",Priimek="Gulin",Podjetje="Djak"},
                new {KupecID=8,Ime="Pavel",Priimek="Gantar",Podjetje="Inn"},
                new {KupecID=9,Ime="David",Priimek="Niven",Podjetje="Inn"},
                new {KupecID=10,Ime="Erik",Priimek="Kompara",Podjetje="Fitnes"}
            };
            var podjetja = new[] {
                new {ImePodjetja="Kolo",Mesto="Nova Gorica",Država="Slovenija"},
                new {ImePodjetja="Djak",Mesto="Nova Gorica",Država="Slovenija"},
                new {ImePodjetja="Fitnes",Mesto="Ljubljana",Država="Slovenija"},
                new {ImePodjetja="Inn",Mesto="Trst",Država="Italija"},
            };

            var o1 = from x in kupci select x.Ime;
            foreach (var s in o1)
            {
                Console.WriteLine(s);
            }

            var o2 = from x in kupci select x;
            foreach (var s in o2)
            {
                Console.WriteLine(s.Ime + " " +s.Priimek);
            }

            var o3 = from x in podjetja where x.Država == "Slovenija" select x;
            foreach (var s in o3)
            {
                Console.WriteLine(s.ImePodjetja);
            }

            var o4 = from x in podjetja where x.Država == "Slovenija" orderby x.ImePodjetja ascending select x;
            foreach (var s in o4)
            {
                Console.WriteLine(s.ImePodjetja);
            }

            var o5 = from x in podjetja select x;
            Console.WriteLine(o5.Count());

            var o6 = from x in podjetja where x.Država == "Italija" select x;
            Console.WriteLine(o6.Count());

            var o7 = (from x in podjetja select x.Država).Distinct();
            Console.WriteLine(o7.Count());

            Console.ReadLine();
        }
    }
}
