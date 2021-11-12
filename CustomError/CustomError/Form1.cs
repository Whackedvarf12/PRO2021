using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomError
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int v = 0;
                if (Int32.Parse(textBox1.Text)>-1)
                {
                    textBox2.Text = "" + Math.Sqrt(v);
                }
                else
                {
                    throw new NegativnoException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("format");
            }
            catch (NegativnoException f)
            {
                MessageBox.Show(f+"");
            }
        }
    }
}
