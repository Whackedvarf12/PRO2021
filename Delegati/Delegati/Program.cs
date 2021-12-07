using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    class Program
    {
        public delegate bool funZaNiz(string s);
        public static List<string> delajOperacije(string[] nizi, funZaNiz funkcija)
        {
            List<string> a = new List<string>();
            foreach (string i in nizi)
            {
                if (funkcija(i))
                {
                    a.Add(i);
                }
                
            }
            return a;
        }
        public static bool ZacniZA(string s)
        {
            return s.StartsWith("A");
        }
        public static bool KoncaZN(string s)
        {
            return s.EndsWith("n");
        }
        static void Main(string[] args)
        {
            string[] nizi = { "ab", "bc", "cd", "de", "ef", "fg", "gh", "hi", "ij", "ja" };
            List<string> aji = delajOperacije(nizi, ZacniZA);
            List<string> nji = delajOperacije(nizi, KoncaZN);

            foreach (string z in aji)
            {
                Console.WriteLine(z);
            }
            foreach (string z in nji)
            {
                Console.WriteLine(z);
            }

            string option = Console.ReadLine();
            string crka = Console.ReadLine();
            //if (option.Equals("1"))
            //{
            //    foreach (string i in nizi)
            //    {
            //        if (i.ElementAt(0).Equals("d"))
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}

        }
    }
}
