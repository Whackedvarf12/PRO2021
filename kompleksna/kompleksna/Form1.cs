using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kompleksna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            Komp prvo = new Komp();
            prvo.Re = double.Parse(txtre1.Text);
            prvo.Im = double.Parse(txtim1.Text);
            Komp drugo = new Komp();
            drugo.Re = double.Parse(txtre2.Text);
            drugo.Im = double.Parse(txtim2.Text);
            label7.Text = prvo.ToString();
            label8.Text = drugo.ToString();
            label9.Text = (prvo + drugo).ToString();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            Komp prvo = new Komp();
            prvo.Re = double.Parse(txtre1.Text);
            prvo.Im = double.Parse(txtim1.Text);
            Komp drugo = new Komp();
            drugo.Re = double.Parse(txtre2.Text);
            drugo.Im = double.Parse(txtim2.Text);
            label7.Text = prvo.ToString();
            label8.Text = drugo.ToString();
            label9.Text = (prvo - drugo).ToString();
        }

        private void btnkrat_Click(object sender, EventArgs e)
        {
            Komp prvo = new Komp();
            prvo.Re = double.Parse(txtre1.Text);
            prvo.Im = double.Parse(txtim1.Text);
            Komp drugo = new Komp();
            drugo.Re = double.Parse(txtre2.Text);
            drugo.Im = double.Parse(txtim2.Text);
            label7.Text = prvo.ToString();
            label8.Text = drugo.ToString();
            label9.Text = (prvo * drugo).ToString();
        }
    }
}
