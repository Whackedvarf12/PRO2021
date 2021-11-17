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
            String pot = Res.pot;
            try
            {
                d.zapst=int.Parse(txtzast.Text);
                txtstatus.Text = "Ok";
            }
            catch(FormatException){
                MessageBox.Show("err");
                txtzast.Clear();
                txtzast.Focus();
            }

            try
            {
                d.datum = datumpolje.Value;
                txtstatus.Text = "Ok";
            }
            catch (FormatException)
            {
                MessageBox.Show("err");
                datumpolje.Focus();
            }

            try
            {
                d.namen = txtnamen.Text;
                txtstatus.Text = "Ok";
            }
            catch (FormatException)
            {
                MessageBox.Show("err");
                txtnamen.Clear();
                txtnamen.Focus();
            }

            try
            {
                d.vsota = decimal.Parse(txtznesek.Text);
                txtstatus.Text = "Ok";
            }
            catch (FormatException)
            {
                MessageBox.Show("err");
                txtznesek.Clear();
                txtznesek.Focus();
            }

            try
            {
                d.opomba = txtopomba.Text;
                txtstatus.Text = "Ok";
            }
            catch (FormatException)
            {
                MessageBox.Show("err");
                txtopomba.Clear();
                txtopomba.Focus();
            }
            FileStream f = new FileStream(pot+"/dar.dat", FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, d);
            f.Close();
        }
    }
}
