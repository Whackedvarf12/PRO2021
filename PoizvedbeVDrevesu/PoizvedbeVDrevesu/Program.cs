using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace PoizvedbeVDrevesu
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Delaj();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
        static void Delaj()
        {
            Tree<Zaposleni> z = new Tree<Zaposleni>( new Zaposleni { Id = 1, Ime = "Miha", Priimek = "Polanc", Oddelek = "IT" });
            z.Insert(new Zaposleni { Id = 2, Ime = "Andrej", Priimek = "Bratina", Oddelek = "Marketing" });
            z.Insert(new Zaposleni { Id = 4, Ime = "Lucija", Priimek = "Krkoč", Oddelek = "Prodaja" });
            z.Insert(new Zaposleni { Id = 6, Ime = "Peter", Priimek = "Gulin", Oddelek = "IT" });
            z.Insert(new Zaposleni { Id = 3, Ime = "Franc", Priimek = "Milčinski", Oddelek = "Marketing" });
            z.Insert(new Zaposleni { Id = 5, Ime = "Pavel", Priimek = "Matko", Oddelek = "Prodaja" });
            var x=from aa in z select aa.Oddelek;

        }

    }
}
