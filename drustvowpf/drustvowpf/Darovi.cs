using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drustvowpf
{[Serializable]
    public class Darovi
    {
        public int zapst { get; set; }

        public DateTime datum { get; set; }

        public string namen { get; set; }

        public decimal vsota { get; set; }

        public string opomba { get; set; }

    }
}
