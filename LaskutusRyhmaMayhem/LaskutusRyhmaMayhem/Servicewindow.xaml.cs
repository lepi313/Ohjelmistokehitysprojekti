using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace LaskutusRyhmaMayhem
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Servicewindow : Window
    {
        ObservableCollection<Service> customerList = new ObservableCollection<Service>();
       
        public Servicewindow()
        {
            InitializeComponent();
          


        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var servicelevel = Servicelevel.Text;
            var mprice = Monthlyprice.Text;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Servicelevel_GotFocus(object sender, RoutedEventArgs e)
        {
            this.Servicelevel.SelectAll();
        
        }
        private void Monthlyprice_GotFocus(object sender, RoutedEventArgs e)
        {
            this.Monthlyprice.SelectAll();
      
        }

       

        private void add_servicelevel_Click(object sender, RoutedEventArgs e)
        {
            Allinone.Text = Servicelevel.Text + "-taso:  " + Monthlyprice.Text + " Euroa";
            
        }

        private void Allinone_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}












