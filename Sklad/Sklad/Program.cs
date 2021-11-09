using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class Program
    {
        static void Main(string[] args)
        {
            PovezanaLista<int, String> p = new PovezanaLista<int, String>();
            p.Dodaj(1, "A");
            p.Dodaj(2, "B");
            p.Dodaj(3, "C");
            Console.WriteLine(p.Najdi(2));
            Console.Read();

        }
    }
}
