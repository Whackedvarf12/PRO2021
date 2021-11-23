using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drustvo
{
    public partial class Tiskanje : Form
    {
        private Font printFont;
        private String pot = Res.pot;
        private List<Darovi> vsi= new List<Darovi>();
        private List<Darovi> filter = new List<Darovi>();
        decimal znesekVDobro = 0;
        decimal znesekVBreme = 0;
        decimal saldo = 0;
        public void naloziPod()
        {
            FileStream fs = new FileStream(pot, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                while (true)
                {
                    Darovi d = (Darovi)bf.Deserialize(fs);
                    vsi.Add(d);
                }
            }
            catch (SerializationException)
            {

            }
            fs.Close();
        }
        public void preveriDatum()
        {
            DateTime oddt = dtod.Value;
            DateTime dodt = dtdo.Value;
            foreach (Darovi d in vsi)
            {
                if (d.datum >= oddt && d.datum <= dodt)
                {
                    filter.Add(d);
                }
            }
        }

        public Tiskanje()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tiskanje_Load(object sender, EventArgs e)
        {
            naloziPod();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0; // število vrstic na stran
            float yPos = 0; // y pozicija
            int count = 0; // število vseh izpisanih vrstic
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null; // vrstica za izpis
            int štVrstice = 0;
            RačunajVsote(); // metoda za izračun vsot
            // število vrstic na eno stran, zapisov je lahko veliko
            linesPerPage = ev.MarginBounds.Height /
            printFont.GetHeight(ev.Graphics);
            //prva vrstica – naslov dokumenta
            line = "Izpis vseh darov in izdatkov za Karitas";
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris slike
            // Bitmap bi = new Bitmap(@"D:\Pro2\Društvo\Društvo\Resources\a.gif");
            // ev.Graphics.DrawImage(bi, ev.MarginBounds.Right - 70, yPos - 10);
            //zaradi velikosti slike zgornjemu robu prištejem 32 (velikost=32x32)
            topMargin += 32;
            line = "";
            //izris prazne vrstice
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris črte
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawLine(new Pen(Color.Black), ev.MarginBounds.Left, yPos, ev.MarginBounds.Right, yPos);
            count++;
            //izpis glave tabele
            line = "Poz. Datum Namen V dobro V breme Opombe";
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            //izris črte
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawLine(new Pen(Color.Black), ev.MarginBounds.Left, yPos, ev.MarginBounds.Right, yPos);
            count++;
            // Izpis podatkov iz datoteke.
            while (count < linesPerPage && štVrstice < filter.Count)
            {
                string a; //namen skrajšan na 10 znakov
                string b; //opombe skrajšane na 10 znakov
                if (filter[štVrstice].namen.Length > 10)
                    a = filter[štVrstice].namen.Substring(0, 10);
                else a = filter[štVrstice].namen;
                if (filter[štVrstice].opomba.Length > 10)
                    b = filter[štVrstice].opomba.Substring(0, 10);
                else b = filter[štVrstice].opomba;
                decimal c = filter[štVrstice].vsota; //v dobro ali breme?
                if (c > 0)
                    line = String.Format("{0,3}", (štVrstice + 1)) + " " + filter[štVrstice].datum.ToShortDateString() + " " +

                    String.Format("{0,10}", a) + " " +
                    String.Format("{0,10:c}", filter[štVrstice].vsota) + " " +
                    String.Format("{0,10}", b);
                else
                    line = String.Format("{0,3}", (štVrstice + 1)) + " " + filter[štVrstice].datum.ToShortDateString() + " " +
                    String.Format("{0,10}", a) + " " +
                    String.Format("{0,10:c}", filter[štVrstice].vsota) + " " +
                    String.Format("{0,10}", b);
                štVrstice++;
                yPos = topMargin + (count *
                printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                count++;
                line = "";
            }
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawLine(new Pen(Color.Black), ev.MarginBounds.Left, yPos, ev.MarginBounds.Right, yPos);
            count++;
            //izpis vrstice skupaj
            line = String.Format("{0,24}", "Skupaj") + " " +
            String.Format("{0,10:c}", znesekVDobro) + " " +
            String.Format("{0,10:c}", znesekVBreme) + " " +
            String.Format("{0,10:c}", saldo);
            yPos = topMargin + (count *
            printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
            leftMargin, yPos, new StringFormat());
            count++;
            // če še nismo na koncu datoteke, pojdi na novo stran
            if (štVrstice != filter.Count)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void RačunajVsote()
        {
            znesekVBreme = 0;
            znesekVDobro = 0;
            saldo = 0;
            foreach (Darovi d in filter)
            {
                if (d.vsota > 0)
                {
                    znesekVDobro += d.vsota;
                }
                else
                {
                    znesekVDobro -= d.vsota;
                }
            }
            saldo = znesekVDobro + znesekVBreme;
        }

        private void btnnatisni_Click(object sender, EventArgs e)
        {
            preveriDatum();
            DialogResult a = printDialog1.ShowDialog();
            printFont = new Font("Arial", 14);
            if (a==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
