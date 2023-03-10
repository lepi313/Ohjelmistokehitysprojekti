using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LaskutusRyhmaMayhem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Invoice> mainInvoiceList = new ObservableCollection<Invoice>();
        public MainWindow()
        {
            InitializeComponent();
            string jsonpath = "invoicelist.json";
            if (File.Exists(jsonpath))
            {
                try
                {
                    var invoicestring = File.ReadAllText("invoicelist.json");
                    var invoices = JsonSerializer.Deserialize<List<Invoice>>(invoicestring);
                    if (invoices != null)
                    {
                        foreach (var invoice in invoices)
                        {
                            mainInvoiceList.Add(invoice);
                        }
                        listViewInvoices.ItemsSource = mainInvoiceList;

                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void palvelutasot_Click(object sender, RoutedEventArgs e)
        {
            Servicewindow addService = new Servicewindow();
            addService.Show();
        }
        private void Maksut_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var invoicestring = File.ReadAllText("invoicelist.json");
                var invoices = JsonSerializer.Deserialize<List<Invoice>>(invoicestring);
                if (invoices != null)
                {
                    mainInvoiceList.Clear();
                    foreach (var invoice in invoices)
                    {
                        mainInvoiceList.Add(invoice);
                    }
                    listViewInvoices.ItemsSource = mainInvoiceList;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow addCustomer = new CustomerWindow();
            addCustomer.ShowDialog();
        }

        private void buttonPrintFile_Click(object sender, RoutedEventArgs e)
        {
            var printDialog = new System.Windows.Controls.PrintDialog();

            bool? result = printDialog.ShowDialog();

            if (result == true)
            {
                printDialog.PrintVisual(listViewInvoices, "Print invoices");
            }
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            var jsoninvoice = JsonSerializer.Serialize(mainInvoiceList);
            File.WriteAllText("invoicelist.json", jsoninvoice);
            Close();
        }
    }
}


        
    

