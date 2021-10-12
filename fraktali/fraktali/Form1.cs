using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fraktali
{
    public partial class Form1 : Form
    {
        private double x;
        private double y;
        private double alfa;
        public Form1()
        {
            InitializeComponent();
        }
        private int risaniX(double xr)
        {
            return (int)Math.Round(this.Width * xr);
        }

        private int risaniy(double yr)
        {
            return (int)Math.Round(this.Height - this.Height * yr);
        }
        public void obratLevo(double kot)
        {
            alfa = alfa + kot;
        }
        public void premik(double d, Graphics g)
        {
            double stariX = x;
            double stariY = y;
            x = x + d * Math.Cos(alfa * Math.PI / 180);
            y = y + d * Math.Sin(alfa * Math.PI / 180);
            int x1 = risaniX(stariX);
            int y1 = risaniy(stariY);
            int x2 = risaniX(x);
            int y2 = risaniy(y);
            g.DrawLine(new Pen(Color.Black, width: 3), x1, y1, x2, y2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            /*x = 0.5;
            y = 0.1;
            alfa = 0;
            for(int k=0; k<6; k++)
            {
                double korak = 0.2;
                premik(korak, g);
                obratLevo(360 / 6);
            }*/

            /*Random r = new Random();
            x = 0.5;
            y = 0.5;
            alfa = 0;
            for (int k = 0; k < 10000; k++)
            {
                obratLevo(r.Next(360));
                premik(0.1, g);
            }*/

            /*x = 0.4;
            y=0.1;
            alfa = 0;
            int n = 9;
            for (int k=0;k<6;k++)
            {
                koch(n, 1 / Math.Pow(3, n)/3, g);
                obratLevo(360 / 6);
            }*/

            int n = 10;
            drevo(n, 0.5, 0, 90, 0.3, g);
        }
        public void koch(int n, double korak, Graphics g)
        {
            if (n == 0)
            {
                premik(korak, g);
                return;
            }
            koch(n - 1, korak, g);
            obratLevo(60);
            koch(n-1, korak, g);
            obratLevo(-120);
            koch(n - 1, korak, g);
            obratLevo(60);
            koch(n - 1, korak, g);
        }
        public void drevo(int n, double x, double y, double a, double dolzina, Graphics g)
        {
            double cx = x + dolzina * Math.Cos(a * Math.PI / 180);
            double cy = y + dolzina * Math.Sin(a * Math.PI / 180);
            int x1 = risaniX(cx);
            int y1 = risaniy(cy);
            int x2 = risaniX(x);
            int y2 = risaniy(y);
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            Pen p = new Pen(c,(float)(Math.Pow(n,1.2)));
            g.DrawLine(p, x1, y1, x2, y2);
            if (n == 0)
            {
                return;  
            }
            drevo(n - 1, cx, cy, a - 69, dolzina * 0.65, g);
            drevo(n - 1, cx, cy, a + 69, dolzina * 0.65, g);
            drevo(n - 1, cx, cy, a, dolzina * (1-0.65), g);
        }
    }
}
