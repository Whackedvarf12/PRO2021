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
using System.Xml.Serialization;

namespace drustvowpf
{
    /// <summary>
    /// Interaction logic for Zasciti.xaml
    /// </summary>
    public partial class Zasciti : Window
    {
        List<Darovi> sprem = new List<Darovi>();
        public Zasciti()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FileStream f = new FileStream("d:\\PRO2021\\darwpf.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Darovi d;
                try
                {
                    while (f.CanRead==true)
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
            finally
            {
                try
                {
                    FileStream fs = new FileStream("d:\\PRO2021\\darwpf.xml", FileMode.Create);
                    XmlSerializer xmls = new XmlSerializer(typeof(List<Darovi>));
                    xmls.Serialize(fs, sprem);
                    fs.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("err");
                }
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FileStream fxml = new FileStream("d:\\PRO2021\\darwpf.xml", FileMode.Open);
            XmlSerializer xmls = new XmlSerializer(typeof(List<Darovi>));
            try
            {
                sprem = (List<Darovi>)xmls.Deserialize(fxml);
            }
            catch (SerializationException) { }
            finally { fxml.Close(); }
            try
            {

            }
        }
    }
}
