using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad
{
    class PovezanaLista<K,T> where K:IComparable
    {
        public Vozel<K,T> Glava;
        public PovezanaLista()
        {
            Glava = new Vozel<K,T>();
        }
        public void Dodaj(K key, T item)
        {
            Vozel<K, T> nov = new Vozel<K, T>(key, item, Glava.Naslednji);
            Glava.Naslednji = nov;
        }
        public T Najdi(K ka)
        {
            Vozel<K, T> trenutni = Glava;
            while (trenutni.Naslednji!=null)
            {
                if (trenutni.Key.CompareTo(ka)==0)
                {
                    break;
                }
                else
                {
                    trenutni = trenutni.Naslednji;
                }
            }
            return trenutni.Item;
        }
    }
}
