using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drustvo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void vnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vnos a = new Vnos();
            a.Show();
        }

        private void pogledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pregled a = new Pregled();
            a.Show();
        }

        private void tiskanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tiskanje a = new Tiskanje();
            a.Show();
        }
    }
}
