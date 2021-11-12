using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomError
{
    class NegativnoException:ApplicationException
    {
        public NegativnoException() : base("neg") { }
        public NegativnoException(String s) : base("neg"+s) { }
    }
}
