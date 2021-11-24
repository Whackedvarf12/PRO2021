using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace drustvowpf
{
    /// <summary>
    /// Interaction logic for Pregled.xaml
    /// </summary>
    public partial class Pregled : Window
    {
        List<Darovi> sprem = new List<Darovi>();
        //String pot = Res.pot;
        public Pregled()
        {
            InitializeComponent();
        }
        private void Pregled_Load()
        {

            try
            {
                FileStream f = new FileStream("d:\\PRO2021\\darwpf.dat", FileMode.Open);
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

                }
            }
            catch (Exception)
            {

            }

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Pregled_Load();
            dg.ItemsSource = sprem;
        }
    }
}
