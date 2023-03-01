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
        public CustomerWindow()
        {
            InitializeComponent();
            listViewCustomers.ItemsSource = customerList;
            this.textBoxCustomerZipCode.SelectAll();
        }



        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            customerWindow.Close();
        }
        
        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            var customername = textBoxCustomerName.Text;
            var customeraddress = textBoxCustomerAddress.Text;
            var customerzipcode = textBoxCustomerZipCode.Text;
            var customercity = textBoxCustomerCity.Text;
            var customeremail = textBoxCustomerEmail.Text;
            DateTime? firstbillingdate = datePickerBillingDate.SelectedDate;
            Customer customer = new Customer(customername, customeraddress, customerzipcode, customercity, customeremail, firstbillingdate);
            File.WriteAllText("customers.json", JsonSerializer.Serialize(customer));
            customerList.Add(customer);
        }

        private void textBoxCustomerAddress_GotFocus(object sender, RoutedEventArgs e)
        {
            this.textBoxCustomerAddress.SelectAll();
        }

        private void textBoxCustomerZipCode_MouseEnter(object sender, MouseEventArgs e)
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

    }
}
