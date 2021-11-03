using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktura
{
    class Program
    {
        struct vektor
        {
            public double x, y, z;
            public double this[int i]
            {
                get
                {
                    switch(i){
                        case 0:
                            return x;
                        case 1:
                            return y;
                        case 2:
                            return z;
                        default:
                            throw new IndexOutOfRangeException("napačen index");
                    }
                }
                set
                {
                    switch (i)
                    {
                        case 0:
                            x=value;
                            break;
                        case 1:
                            y = value;
                            break;
                        case 2:
                            z = value;
                            break;
                        default:
                            throw new IndexOutOfRangeException("napačen index");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            vektor v1;
            v1.x = 1.4;
            v1.y = 55.2;
            v1.z = 6.9;
            for(int k = 0; k < 2; k++)
            {
                v1[k] = 2 * k;
            }
        }
    }
}
