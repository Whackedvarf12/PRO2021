using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using static json.Pod;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            Učilnica u = JsonConvert.DeserializeObject<Učilnica>(
                File.ReadAllText(@"D:\PRO2021\json\json\pod.json")
            );
            foreach (var p in u.Poglavja)
            {
                Console.WriteLine(p.name);
            }
            Console.ReadLine();
        }
    }
}
