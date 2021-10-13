using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBlyat
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 janez = new Class1();
            janez.Ime = "Janez Novak";
            janez.beleziKlic(10, 1);
            Console.WriteLine(janez.Ime+" "+janez.Stanje);
            Console.Read();
        }
    }
}
