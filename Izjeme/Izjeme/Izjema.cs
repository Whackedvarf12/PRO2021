using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    class Izjema:ApplicationException
    {
        public Izjema() : base("error alert") { }
        public Izjema(String sp) : base(sp + " alert") { }
    }
}
