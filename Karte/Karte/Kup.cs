using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karte
{
    class Kup
    {
        public List<Karta> karte;
        Random r = new Random();
        public Kup()
        {
            karte = new List<Karta>();
            for (int b = 0; b <= 3; b++)
            {
                for (int v = 0; v <= 12; v++) {
                    karte.Add(new Karta((Vrednosti)v, (Barve)b));
                }
            }
        }
        public Kup(bool c, int size)
        {
            if (c==false && size==0)
            {
                karte = new List<Karta>();
            }
            else
            {
                karte = new List<Karta>();
                for (int b = 0; b <= 3; b++)
                {
                    for (int v = 0; v <= 12; v++)
                    {
                        if (v == 10)
                        {
                            return;
                        }
                        karte.Add(new Karta((Vrednosti)v, (Barve)b));
                    }
                }
            }
        }
        public Kup(IEnumerable<Karta> zacetek)
        {
            karte = new List<Karta>(zacetek);
        }
        public void Add(Karta nova)
        {
            karte.Add(nova);
        }
        public int Count(){
            return karte.Count();
        }
        public void Sort()
        {
            karte.Sort(new Primerjava());
        }
        public void Mesaj()
        {
            List<Karta> novekarte = new List<Karta>();
            while (karte.Count>0)
            {
                int zaPremik = r.Next(karte.Count);
                novekarte.Add(karte[zaPremik]);
                karte.RemoveAt(zaPremik);
            }
            karte = novekarte;
        }
        public Karta Deli(int index)
        {
            Karta zaDelitev = karte[index];
            karte.RemoveAt(index);
            return zaDelitev;
        }
        public IEnumerable<String> imenaKart()
        {
            String[] imena= new string[karte.Count];
            for (int i=0;i<karte.Count;i++)
            {
                imena[i] = karte[i].Ime;
            }
            return imena;
        }
    }
}
