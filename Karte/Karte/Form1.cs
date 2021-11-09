using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karte
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        Kup k1 = new Kup(false, 0);
        Kup k2 = new Kup(false, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Karta k = new Karta((Vrednosti)r.Next(0, 12), (Barve)r.Next(0, 4));
            MessageBox.Show(k.Ime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s = "";
            List<Karta> kup = new List<Karta>();
            for(int i = 0; i < 11; i++)
            {
                Karta karta= new Karta((Vrednosti)r.Next(0, 12), (Barve)r.Next(0, 4));
                kup.Add(karta);
            }
            kup.Sort(new Primerjava());
            
            foreach (Karta x in kup)
            {
                s += x.Ime + Environment.NewLine;
            }
            MessageBox.Show(s);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pon1_Click(object sender, EventArgs e)
        {
            k1 = new Kup();
            kup1.Items.Clear();
            foreach (String k in k1.imenaKart())
            {
                kup1.Items.Add(k);
            }
        }

        private void pon2_Click(object sender, EventArgs e)
        {
            k2 = new Kup(false, 10);
            kup2.Items.Clear();
            foreach (String k in k2.imenaKart())
            {
                kup2.Items.Add(k);
            }
        }

        private void mes1_Click(object sender, EventArgs e)
        {
            k1.Mesaj();
            kup1.Items.Clear();
            foreach (String k in k1.imenaKart())
            {
                kup1.Items.Add(k);
            }
        }

        private void mes2_Click(object sender, EventArgs e)
        {
            k2.Mesaj();
            kup2.Items.Clear();
            foreach (String k in k2.imenaKart())
            {
                kup2.Items.Add(k);
            }
        }

        private void ltor_Click(object sender, EventArgs e)
        {
            int izbrana = kup1.SelectedIndex;
            k2.Add(k1.karte[izbrana]);
            k1.karte.RemoveAt(izbrana);
            kup1.Items.Clear();
            foreach (String k in k1.imenaKart())
            {
                kup1.Items.Add(k);
            }
            kup2.Items.Clear();
            foreach (String k in k2.imenaKart())
            {
                kup2.Items.Add(k);
            }
        }

        private void rtol_Click(object sender, EventArgs e)
        {
            int izbrana = kup2.SelectedIndex;
            k1.Add(k2.karte[izbrana]);
            k2.karte.RemoveAt(izbrana);
            kup1.Items.Clear();
            foreach (String k in k1.imenaKart())
            {
                kup1.Items.Add(k);
            }
            kup2.Items.Clear();
            foreach (String k in k2.imenaKart())
            {
                kup2.Items.Add(k);
            }
        }
    }
}
