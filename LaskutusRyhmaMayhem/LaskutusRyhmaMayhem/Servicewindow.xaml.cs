using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        ObservableCollection<Service> servicelist = new ObservableCollection<Service>();
        public Servicewindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var servicelevel = Servicelevel.Text;
            var mprice = Double.Parse(Monthlyprice.Text);
            Service service = new Service(mprice, servicelevel);
            servicelist.Add(service);
            listViewService.ItemsSource = servicelist;  
            File.WriteAllText("servicelevels.json", JsonSerializer.Serialize(service));
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
            
            listViewService.Items.Add(Servicelevel.Text + "-taso " + Monthlyprice.Text + " Euroa Kuukausihinta");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            servicelist.RemoveAt(listViewService.SelectedIndex);
        }

       
    }
}












