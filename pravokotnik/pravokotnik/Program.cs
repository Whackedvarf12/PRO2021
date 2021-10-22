using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravokotnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik p1 = new Pravokotnik();
            Pravokotnik p2 = new Pravokotnik();
            Pravokotnik p3 = new Pravokotnik(10, 15);
            p1.Sirina = 10;
            p1.Visina = 15;
            p2.Sirina = 25;
            p2.Visina = 10;
            Console.WriteLine("Pravokotnik 1 " + p1.ToString());
            Console.WriteLine("Pravokotnik 2 " + p2.ToString());
            Console.WriteLine("Pravokotnik 3 " + p3.ToString());
            if (p1 == p2)
                Console.WriteLine("p1=p2");
            else
            {
                if (p1 > p2)
                    Console.WriteLine("P1 je večji od P2");
                else
                    Console.WriteLine("P2 je večji od P1");
            }
            if (p1 == p3)
                Console.WriteLine("P1 je enak P3");
            Console.ReadLine();
        }
    }
}
