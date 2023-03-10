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
            string jsonpath = "servicelevels.json";
            if (File.Exists(jsonpath))
            {
                try
                {
                    var servicestring = File.ReadAllText("servicelevels.json");
                    var services = JsonSerializer.Deserialize<List<Service>>(servicestring);
                    if (services != null)
                    {
                        foreach (var service in services)
                        {
                            servicelist.Add(service);
                        }
                        listViewService.ItemsSource = servicelist;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var servicelevel = Servicelevel.Text;
                var mprice = Double.Parse(Monthlyprice.Text);
                Service service = new Service(mprice, servicelevel);
                servicelist.Add(service);
                listViewService.ItemsSource = servicelist;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
            var jsonservice = JsonSerializer.Serialize(servicelist);
            File.WriteAllText("servicelevels.json", jsonservice);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                servicelist.RemoveAt(listViewService.SelectedIndex);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

       
    }
}












