using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[1];
            try
            {
                Console.WriteLine(i[3]);
            }
            catch (Izjema e)
            {

            }
        }
    }
}
