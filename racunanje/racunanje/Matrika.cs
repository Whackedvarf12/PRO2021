using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace racunanje
{
    class Matrika
    {
        public int[,] m = new int[3, 3];
        public int this[int i, int j]
        {
            get
            {
                return m[i, j];
            }
            set
            {
                m[i, j] = value;
            }
        }
        public override string ToString()
        {
            String s = "";
            for (int i=0;i<3;i++)
            {
                for (int j=0;j<3;j++)
                {
                    s += m[i,j]+", ";
                }
                s += "\n";
            }
            return s;
        }
        public static Matrika operator *(Matrika a, Matrika b)
        {
            Matrika c = new Matrika();
            for(int i=0;i<3;i++)
            {
                for (int j=0;j<3;j++)
                {
                    c[i,j]=a[i,0]*b[0,j]+ a[i, 1] * b[1, j]+a[i, 2] * b[2, j];
                }
            }
            return c;
        }
    }
}
