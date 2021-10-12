using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortiranje
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a = new int[50000];
            Random r = new Random();
            for (int k = 0; k < 50000; k++)
            {
                a[k] = r.Next(50000);
            }
                DateTime d = DateTime.Now;
                vstavljanje(a);
                DateTime d1 = DateTime.Now;
                TimeSpan ts = d1 - d;
            Console.WriteLine(ts);
            //izpis(a);
            izbiranje(a);
            
            Console.Read();
        }
        static void izbiranje(int[] a)
        {
            for(int k=0; k<a.Length-1; k++)
            {
                int min = a[k];
                int minIneks = k;
                for (int j=k; j<a.Length; j++)
                {
                    if (a[j]<min)
                    {
                        min = a[j];
                        minIneks = j;
                    }
                }
                int temp = a[k];
                a[k] = a[minIneks];
                a[minIneks] = temp;
                //izpis(a);
            }
        }

        static void vstavljanje(int[] a)
        {
            for (int k=1;k<a.Length;k++)
            {
                int j = k;
                int temp = a[k];
                while (j>0 && a[j-1]>temp)
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = temp;
                //izpis(a);
            }
        }
        static void izpis(int[] a)
        {
            for (int k=0;k<a.Length;k++)
            {
                Console.Write(a[k]+"\t");
            }
            Console.WriteLine("");
        }
    }
}
