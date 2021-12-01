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
using System.Windows.Shapes;

namespace Nepovezan
{
    /// <summary>
    /// Interaction logic for Racuni.xaml
    /// </summary>
    public partial class Racuni : Window
    {
        public Racuni()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Nepovezan.AdventureWorksLT2012_DataDataSet adventureWorksLT2012_DataDataSet = ((Nepovezan.AdventureWorksLT2012_DataDataSet)(this.FindResource("adventureWorksLT2012_DataDataSet")));
            // Load data into the table SalesOrderHeader. You can modify this code as needed.
            Nepovezan.AdventureWorksLT2012_DataDataSetTableAdapters.SalesOrderHeaderTableAdapter adventureWorksLT2012_DataDataSetSalesOrderHeaderTableAdapter = new Nepovezan.AdventureWorksLT2012_DataDataSetTableAdapters.SalesOrderHeaderTableAdapter();
            adventureWorksLT2012_DataDataSetSalesOrderHeaderTableAdapter.Fill(adventureWorksLT2012_DataDataSet.SalesOrderHeader);
            System.Windows.Data.CollectionViewSource salesOrderHeaderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("salesOrderHeaderViewSource")));
            salesOrderHeaderViewSource.View.MoveCurrentToFirst();
        }
    }
}
