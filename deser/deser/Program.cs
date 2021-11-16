using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static deser.Pod;

namespace deser
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"D:\PRO2021\deser\deser\pod.xml", FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(IzdaniRacunEnostavni));
            IzdaniRacunEnostavni a = (IzdaniRacunEnostavni)xml.Deserialize(f);
            foreach (var x in a.Racun.PostavkeRacuna)
            {
                Console.WriteLine(x.OpisiArtiklov.OpisArtikla.OpisArtikla1+" "+x.KolicinaArtikla.Kolicina+" "+x.ZneskiPostavke.ZnesekPostavke);
            }
            Console.ReadLine();
        }
    }
}
