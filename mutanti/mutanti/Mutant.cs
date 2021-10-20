using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    abstract class Mutant : inter
    {
        public String ime{get; set;}
        public int stopnja { get; set; }
        public abstract int nevarnost();
        public void info()
        {
            Console.WriteLine(ime);
            Console.WriteLine(nevarnost());
        }
    }
}
