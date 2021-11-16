using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace pisanjebin
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime now = DateTime.Now;
            //FileStream s = new FileStream("e.txt", FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(s, now);
            //s.Close();
            FileStream f = new FileStream(@"e.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            DateTime t = (DateTime)bf.Deserialize(f);
            Console.WriteLine(t);
            Console.ReadLine();

        }
    }
}
