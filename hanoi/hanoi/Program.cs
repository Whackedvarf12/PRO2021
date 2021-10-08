using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            premakni(40, "a", "b", "c");
            Console.Read();
        }
        static void premakni(int n, String zacetni, String koncni, String pomozni)
        {
            if (n==1)
            {
                Console.WriteLine("Premakni iz "+zacetni+" na "+koncni);
                return;
            }
            premakni(n-1, zacetni, pomozni, koncni); //1. is a na b, pomagaj si s cs
            Console.WriteLine("Premakni iz " + zacetni + " na " + koncni);
            premakni(n-1, pomozni, koncni, zacetni);
        }
    }
}
