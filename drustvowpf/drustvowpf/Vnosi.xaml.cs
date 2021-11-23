using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    /// Interaction logic for Vnosi.xaml
    /// </summary>
    public partial class Vnosi : Window
    {
        public Vnosi()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Darovi d = new Darovi();
            try
            {
                d.zapst = int.Parse(txtzap.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("err");
                txtzap.Clear();
                txtzap.Focus();
            }

            try
            {
                d.datum = (DateTime)txtdatum.SelectedDate;
            }
            catch (FormatException)
            {
                MessageBox.Show("err");
                txtdatum.Focus();
            }

            try
            {
                d.namen = txtnamen.Text;
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
            }
            catch (FormatException)
            {
                MessageBox.Show("err");
                txtopomba.Clear();
                txtopomba.Focus();
            }
            FileStream f = new FileStream("d:\\PRO2021\\darwpf.dat", FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, d);
            MessageBox.Show("dela");
            f.Close();
        }
    }
    
}
