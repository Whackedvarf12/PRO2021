using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static meteor.Vreme;

namespace meteor
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream s = new FileStream(@"D:\PRO2021\meteor\meteor\met.xml", FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(AGROMET));
            AGROMET a = (AGROMET)xml.Deserialize(s);
            foreach(AGROMETDATA x in a.DATA)
            {
                Console.WriteLine(x.Temp2_Max+" "+x.Date);
            }
            Console.Read();
        }
    }
}
