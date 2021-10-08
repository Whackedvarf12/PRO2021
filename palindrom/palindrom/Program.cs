using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(jePal("pericarezeracirep"));
            Console.Read();
        }
        static bool jePal(String niz)
        {
            if (niz.Length == 1 || niz.Length == 0)
            {
                return true;
            }
            else if (niz.First().Equals(niz.Last()))
            {
                return jePal(niz.Substring(1,niz.Length-2));
            }
            else
            {
                return false;
            }

        }
    }
}
