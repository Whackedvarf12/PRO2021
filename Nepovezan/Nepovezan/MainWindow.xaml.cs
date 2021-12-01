using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nepovezan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nepovezan.AdventureWorksLT2012_DataDataSet dataset;
        AdventureWorksLT2012_DataDataSetTableAdapters.ProductTableAdapter ta;
        CollectionViewSource PVC;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dataset = ((Nepovezan.AdventureWorksLT2012_DataDataSet)(this.FindResource("adventureWorksLT2012_DataDataSet")));
            // Load data into the table Product. You can modify this code as needed.
            ta = new Nepovezan.AdventureWorksLT2012_DataDataSetTableAdapters.ProductTableAdapter();
            ta.Fill(dataset.Product);
            PVC = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
            PVC.View.MoveCurrentToFirst();
        }

        private void naprej_Click(object sender, RoutedEventArgs e)
        {
            int dolzina = ((CollectionView)PVC.View).Count;
            int pozicija = PVC.View.CurrentPosition;
            if (pozicija < dolzina-1)
            {
                PVC.View.MoveCurrentToNext();
            }
        }

        private void nazaj_Click(object sender, RoutedEventArgs e)
        {
            int dolzina = ((CollectionView)PVC.View).Count;
            int pozicija = PVC.View.CurrentPosition;
            if (pozicija > 0)
            {
                PVC.View.MoveCurrentToPrevious();
            }
        }

        private void shrani_Click(object sender, RoutedEventArgs e)
        {
            ta.Update(dataset.Product);
        }
    }
}
