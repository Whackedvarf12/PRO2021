using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutant[] m = new Mutant[6];
            Psychic ps1 = new Psychic();
            ps1.ime = "Kkompara";
            ps1.iq = 150;
            ps1.stopnja = 3;
            ps1.uporaba = 2;
            m[0] = ps1;
            Psychic ps2 = new Psychic();
            ps2.ime = "Vodopivec";
            ps2.iq = 100;
            ps2.stopnja = 3;
            ps2.uporaba = 2;
            m[1] = ps2;
            Tank ps3 = new Tank();
            ps3.ime = "Čeho";
            ps3.iq = 80;
            ps3.stopnja = 3;
            ps3.moc = 30;
            m[2] = ps3;
            Tank ps4 = new Tank();
            ps4.ime = "Bog";
            ps4.iq = 100;
            ps4.stopnja = 3;
            ps4.moc = 20;
            m[3] = ps4;
            Elemental ps5 = new Elemental();
            ps5.ime = "Bojana";
            ps5.stopnja = 4;
            ps5.podrocje = 7;
            m[4] = ps5;
            Elemental ps6 = new Elemental();
            ps6.ime = "Vouk";
            ps6.stopnja = 5;
            ps6.podrocje = 6;
            m[5] = ps6;
            foreach (Mutant m1 in m)
                m1.info();
            Console.ReadLine();

        }
    }
}
