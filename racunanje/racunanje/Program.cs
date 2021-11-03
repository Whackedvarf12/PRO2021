using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace racunanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrika x = new Matrika();
            x[0,0]=1;
            x[0, 1] = -1;
            x[0, 2] = 1;
            x[1, 0] = 2;
            x[1, 1] = 0;
            x[1, 2] = -1;
            x[2, 0] = 3;
            x[2, 1] = 2;
            x[2, 2] = 1;
            Matrika y = new Matrika();
            y[0, 0] = 1;
            y[0, 1] = -1;
            y[0, 2] = 1;
            y[1, 0] = 2;
            y[1, 1] = 0;
            y[1, 2] = -1;
            y[2, 0] = 3;
            y[2, 1] = 2;
            y[2, 2] = 1;
            Console.WriteLine((x*y).ToString());
            Console.ReadLine();
        }
    }
}
