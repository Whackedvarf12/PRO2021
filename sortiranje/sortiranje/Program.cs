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
            
            int[] a = {5, 34, 1, 324, 546, 29, 871, 413 };
            double[] d = {4.12, 541.34, 34.1, 96.35, 69.69 };
            String[] s = {"kuku lele", "alo", "jao", "kva", "bre", "ludnica", "ajde"};
            /*Random r = new Random();
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
            //izbiranje(a);*/
            //quickSortD(0, d.Length-1, d);
            quickSortS(0, s.Length-1, s);

            
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

        static void izpis(String[] a)
        {
            for (int k=0;k<a.Length;k++)
            {
                Console.Write(a[k]+"\t");
            }
            Console.WriteLine("");
        }

        static int pivot(int zac, int konec, int[] tab)
        {
            int p = tab[zac];
            int m = zac;
            int n = konec + 1;
            do
            {
                m = m + 1;
            } while (tab[m]<=p && m < konec);
            do
            {
                n = n - 1;
            } while (tab[n] > p);
            while (m<n)
            {
                int temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                {
                    m = m + 1;
                } while (tab[m] <= p);
                do
                {
                    n = n - 1;
                } while (tab[n] > p);
            }
            int temp2 = tab[n];
            tab[n] = tab[zac];
            tab[zac] = temp2;
            //izpis(tab);
            return n;
        }

        static void quickSort(int zac, int konec, int[] tab)
        {
            if (zac>=konec)
            {
                return;
            }
            else
            {
                int a = pivot(zac, konec, tab);
                quickSort(zac, a-1, tab);
                quickSort(a + 1, konec, tab);
                
            }
        }

        static int pivotD(int zac, int konec, double[] tab)
        {
            double p = tab[zac];
            int m = zac;
            int n = konec + 1;
            do
            {
                m = m + 1;
            } while (tab[m] <= p && m < konec);
            do
            {
                n = n - 1;
            } while (tab[n] > p);
            while (m < n)
            {
                double temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                {
                    m = m + 1;
                } while (tab[m] <= p);
                do
                {
                    n = n - 1;
                } while (tab[n] > p);
            }
            double temp2 = tab[n];
            tab[n] = tab[zac];
            tab[zac] = temp2;
            //izpis(tab);
            return n;
        }

        static void quickSortD(int zac, int konec, double[] tab)
        {
            if (zac >= konec)
            {
                return;
            }
            else
            {
                int a = pivotD(zac, konec, tab);
                quickSortD(zac, a - 1, tab);
                quickSortD(a + 1, konec, tab);

            }
        }

        static int pivotS(int zac, int konec, String[] tab)
        {
            String p = tab[zac];
            int m = zac;
            int n = konec + 1;
            do
            {
                m = m + 1;
            } while (tab[m].CompareTo(p)<0 && m < konec);
            do
            {
                n = n - 1;
            } while (tab[n].CompareTo(p) > 0);
            while (m < n)
            {
                String temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                {
                    m = m + 1;
                } while (tab[m].CompareTo(p) < 0);
                do
                {
                    n = n - 1;
                } while (tab[n].CompareTo(p) > 0);
            }
            String temp2 = tab[n];
            tab[n] = tab[zac];
            tab[zac] = temp2;
            izpis(tab);
            return n;
        }

        static void quickSortS(int zac, int konec, String[] tab)
        {
            if (zac >= konec)
            {
                return;
            }
            else
            {
                int a = pivotS(zac, konec, tab);
                quickSortS(zac, a - 1, tab);
                quickSortS(a + 1, konec, tab);

            }
        }
    }
}
