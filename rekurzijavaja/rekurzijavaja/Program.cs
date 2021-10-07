using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzijavaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(peta(4));
            Console.ReadLine();
        }
        static int potencaIter(int n)
        {
            int pot = 1;
            for (int i=1; i<=n;i++)
            {
                pot = pot * 2;
            }
            return pot;
        }
        static int potencaRek(int n)
        {
            if (n==0)
            {
                return 1;
            }
            else
            {
                return 2 * potencaRek(n - 1);
            }
        }
        static int fib(int n)
        {
            if (n == 1 || n==2)
            {
                return 1;
            }
            else
            {
                return fib(n-1)+fib(n-2);
            }
        }
        static int tretja(int n)
        {
            if (n==1 || n==2)
            {
                return 2;
            }
            else
            {
                return tretja(n-2)*tretja(n-1)-1;
            }
        }
        static int cetrta(int n)
        {
            if (n==1)
            {
                return 2;
            }
            else
            {
                return 3 * cetrta(n - 1) + 2;
            }
        }
        static int peta(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else {
                return peta(n - 1) * 2 + peta(n - 2);
            }
        }
    }
}
