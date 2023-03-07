using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        ObservableCollection<Customer> customerList = new ObservableCollection<Customer>();
        List<Service> serviceList = new List<Service>();
        public CustomerWindow()
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
                            comboBoxServiceLevel.Items.Add(service.ServLevel + " " + service.MPrice.ToString() + "€");
                            serviceList.Add(service);
                        }
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            string jsoncustomer = "customerlist.json";
            if (File.Exists(jsoncustomer))
            {
                try
                {
                    var customerstring = File.ReadAllText("customerlist.json");
                    var customers = JsonSerializer.Deserialize<List<Customer>>(customerstring);
                    if (customers != null)
                    {
                        foreach (var customer in customers)
                        {
                            customerList.Add(customer);
                        }
                        listViewCustomers.ItemsSource = customerList;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            listViewCustomers.ItemsSource = customerList;
            this.textBoxCustomerZipCode.SelectAll();
        }
        private void textBoxCustomerAddress_GotFocus(object sender, RoutedEventArgs e)
        {
            this.textBoxCustomerAddress.SelectAll();
        }
        private void textBoxCustomerZipCode_GotFocus_1(object sender, RoutedEventArgs e)
        {
            this.textBoxCustomerZipCode.SelectAll();
        }
        private void textBoxCustomerName_GotFocus(object sender, RoutedEventArgs e)
        {
            this.textBoxCustomerName.SelectAll();
        }
        private void textBoxCustomerCity_GotFocus(object sender, RoutedEventArgs e)
        {
            this.textBoxCustomerCity.SelectAll();
        }
        private void textBoxCustomerEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            this.textBoxCustomerEmail.SelectAll();
        }
        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            var customername = textBoxCustomerName.Text;
            var customeraddress = textBoxCustomerAddress.Text;
            var customerzipcode = textBoxCustomerZipCode.Text;
            var customercity = textBoxCustomerCity.Text;
            var customeremail = textBoxCustomerEmail.Text;
            var servicelevel = comboBoxServiceLevel.SelectedIndex;
            DateTime? firstbillingdate = datePickerBillingDate.SelectedDate;
            Customer customer = new Customer(customername, customeraddress, customerzipcode, customercity, customeremail, firstbillingdate, serviceList[servicelevel]);
            customerList.Add(customer);
        }
        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            customerWindow.Close();
            var jsoncustomer = JsonSerializer.Serialize(customerList);
            File.WriteAllText("customerlist.json", jsoncustomer);
        }


    }
}
