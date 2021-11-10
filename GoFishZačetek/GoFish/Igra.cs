using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Igra
    {
        private List<Igralec> igralci;
        private Dictionary<Vrednosti, Igralec> kompleti;
        private Kup talon;
        private TextBox textNaFormi;
        public Igra(string i, IEnumerable<string> nasprotniki, TextBox txtIgra)
        {
            Random r = new Random();
            textNaFormi = txtIgra;
            igralci = new List<Igralec>();
            igralci.Add(new Igralec(i, r, textNaFormi));
            foreach (string k in nasprotniki)
                igralci.Add(new Igralec(k, r, textNaFormi));
            kompleti = new Dictionary<Vrednosti, Igralec>();
            talon = new Kup(); //ne pozabi, če kličem brez parametrov
                               // imam tu vse možne karte
            Deli();
            igralci[0].SortRoka();
        }
        private void Deli()
        {
            //Tukaj se igra začne. Premešaj kup daj vsakemu igralcu 5 kart
            // nato kliči metodo IzločiKomplete
            talon.Mešaj();
            foreach(Igralec ig in igralci)
            {
                for (int j=0;j<5;j++)
                {
                    ig.VzemiKarto(talon.Deli());
                }
            }
        }
        public bool IgrajEnKrog(int izbranaKarta)
        {
            //metoda vrača true, če je konec igre, false sicer
            //iščemo izbrano karto, najprej igra igralec 0, nato vsi ostali
            //takoj, ko dobimo morebitne karte od igralcev, igra preveri, če je kaj
            // kompletov, komplete odstrani, po potrebi dodeli igralcu nove karte
            //če zmanjka kart je igre konec
                Vrednosti vrednostVIskanju=igralci[0].Peek(izbranaKarta).Vrednost;
                for (int i=0;i<3;i++)
                {
                    if (i==0)
                    {
                        igralci[0].VprašajZaKarto(igralci, 0, talon, vrednostVIskanju);
                    }
                    else
                    {
                        igralci[1].VprašajZaKarto(igralci, 1, talon);

                        igralci[2].VprašajZaKarto(igralci, 2, talon);
                    }
                    if (IzločiKomplete(igralci [i]))
                    {
                        int stkart = 1;
                        while (stkart<=5 && talon.Count>0)
                        {
                            igralci[i].VzemiKarto(talon.Deli());
                            stkart++;
                        }
                    textNaFormi.Text += igralci[i].Ime + " je potegnil karto." + Environment.NewLine;
                    }
                }
                igralci[0].SortRoka();
                if (talon.Count == 0)
                {
                textNaFormi.Text +="Igre je konec." + Environment.NewLine;
                return true;
                }
                else{
                    return false;
                }

            

        }
        public bool IzločiKomplete(Igralec i)
        {
            //izloči komplete za posameznega igralca in vrne vrednost true
            // če je igralec ostal brez kart
            IEnumerable<Vrednosti> igralceviKompleti = i.IzločiKomplete();
            foreach (Vrednosti iv in igralceviKompleti)
            {
                kompleti.Add(iv, i);
            }
            if (i.ŠtevecKart==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string OpišiKomplete()
        {
            String s = "";
            foreach (Vrednosti v in kompleti.Keys)
            {
                s += kompleti[v].Ime + " ima " + v+Environment.NewLine;
            }
            return s;
        }
        public string ImeZmagovalca()
        {
            //Metoda se kliče na koncu igre. Uporablja svojo strukturo - slovar, v
            // kateri je število vseh kompletov posameznega igralca
            //Najprej pregleda z zanko foreach število kompletov in jih doda v zbirko
            // zmagovalcev

            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Vrednosti v in kompleti.Keys)
            {
                string ime = kompleti[v].Ime;
                if (winners.ContainsKey(ime))
                    winners[ime]++;
                else
                    winners.Add(ime, 1);
            }
            //Nato poišče največjo vrednost kompletov
            int mostBooks = 0;
            foreach (string name in winners.Keys)
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];
            bool tie = false;
            string winnerList = "";
            //določi kateri od igralcev ima to vrednost, lahko jih je več
            foreach (string name in winners.Keys)
                if (winners[name] == mostBooks)
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " in ";
                        tie = true;
                    }
                    winnerList += name;
                }
            winnerList += " z " + mostBooks + " kompleti";
            if (tie)
                return "Neodločeno " + winnerList;
            else
                return winnerList;
        }
        public IEnumerable<string> KarteIgralca()
        {
            //vrni seznam imen igralcev
            return igralci[0].Imena();
        }
        public string OpišiVRokah()
        {
            //izpiši imena igralcev in število kart v rokah
            // izpiši tudi koliko kart je v talonu, opis vrni kot spremenljivko tipa string
            String s = "";
            foreach (Igralec i in igralci)
            {
                s += i.Ime + " ima " + i.ŠtevecKart + " kart." + Environment.NewLine;
            }
            s += "V talonu je " + talon.Count + Environment.NewLine;
            return s;
        }
    }
}
