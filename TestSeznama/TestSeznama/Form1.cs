using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSeznama
{
    public partial class Form1 : Form
    {
        ArrayList a = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            a.Add(txtvnos.Text);
            txtkonzola.Text = "dodan element "+txtvnos.Text;
        }

        private void btnizpis_Click(object sender, EventArgs e)
        {
            txtkonzola.Text ="";
            for (int i=0;i<a.Count;i++)
            {
                txtkonzola.Text += a[i] + Environment.NewLine;
            }
        }

        private void btnodstrni_Click(object sender, EventArgs e)
        {
            for(int i=0; i<a.Count;i++)
            {
                if (a[i].Equals(txtvnos.Text))
                {
                    a.RemoveAt(i);
                }
            }
        }

        private void btnprvi_Click(object sender, EventArgs e)
        {
            txtkonzola.Text = a[0].ToString();
        }

        private void btnzadnji_Click(object sender, EventArgs e)
        {
            txtkonzola.Text = a[a.Count - 1].ToString();
        }

        private void btnjeprazna_Click(object sender, EventArgs e)
        {
            if (a.Count <= 0)
            {
                txtkonzola.Text = "da";
            }
            else
            {
                txtkonzola.Text = "ne";
            }
        }

        private void btnalivsebuje_Click(object sender, EventArgs e)
        {
            if (a.Count>0)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i].Equals(txtvnos.Text))
                    {
                        txtkonzola.Text = "da";
                    }
                    else
                    {
                        txtkonzola.Text = "ne";
                    }
                }
            }
            else
            {
                txtkonzola.Text = "ne";
            }
        }

        private void btnlokacija_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].Equals(txtvnos.Text))
                {
                    txtkonzola.Text =i+"";
                }
            }
        }

        private void btnobrezi_Click(object sender, EventArgs e)
        {
            a.TrimToSize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtkonzola.Text = a.Count + " " + a.Capacity;
        }
    }
}
