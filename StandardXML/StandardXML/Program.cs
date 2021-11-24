using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace StandardXML
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = new FileStream("d:\\PRO2021\\liga.xml", FileMode.Create);
            XmlSerializer bf = new XmlSerializer(typeof(VsiSKupaj));
            VsiSKupaj v = new VsiSKupaj();
            bf.Serialize(fs, v);
            fs.Close();
            VsiSKupaj s = null;
            FileStream fs1 = new FileStream("d:\\PRO2021\\liga.xml", FileMode.Open);
            XmlSerializer bf2 = new XmlSerializer(typeof(VsiSKupaj));
            try
            {
                s = (VsiSKupaj)bf.Deserialize(fs1);
            }
            catch (SerializationException) { }
            finally { fs1.Close(); }
            foreach (Moštvo a in s.liga)
            {
                Console.WriteLine(a.Ime);
            }
            //VsiSKupaj v2= new VsiSKupaj();
            //string json = JsonConvert.SerializeObject(v, Formatting.Indented);

            //FileStream fs2 = new FileStream("d:\\PRO2021\\liga.json", FileMode.Create);
            //StreamWriter s2 = new StreamWriter(fs2);
            //s2.Write(json);
            //s2.Close();
            //VsiSKupaj vs2 = JsonConvert.DeserializeObject<VsiSKupaj>(
            //    File.ReadAllText("d:\\PRO2021\\liga.json"));
            //foreach (Moštvo a in v2.liga)
            //{
            //    Console.WriteLine(a.Ime);
            //}
            
            Console.ReadLine();
        }
    }
}
