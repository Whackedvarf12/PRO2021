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
    public partial class Pregled : Form
    {
        List<Darovi> sprem = new List<Darovi>();
        String pot = Res.pot;
        public Pregled()
        {
            InitializeComponent();
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (SerializationException)
            {
                try
                {
                    FileStream f = new FileStream(pot+"/dar.dat", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    Darovi d;
                    try
                    {
                        while (true)
                        {
                            d = (Darovi)bf.Deserialize(f);
                            sprem.Add(d);
                        }
                    }
                    catch (SerializationException)
                    {
                        dataGridView1.DataSource=sprem;
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void Pregled_Shown(object sender, EventArgs e)
        {

        }
    }
}
