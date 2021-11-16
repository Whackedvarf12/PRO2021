using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace drustvo
{
    public partial class Vnos : Form
    {
        public Vnos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvnos_Click(object sender, EventArgs e)
        {
            Darovi d = new Darovi();
            d.zapst = int.Parse(txtzast.Text);
            d.datum = datumpolje.Value;
            d.namen = txtnamen.Text;
            d.vsota = decimal.Parse(txtznesek.Text);
            d.opomba = txtopomba.Text;
            FileStream f = new FileStream("dar.dat", FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, d);
            f.Close();
        }
    }
}
