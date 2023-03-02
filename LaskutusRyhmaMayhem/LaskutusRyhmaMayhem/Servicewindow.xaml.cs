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

namespace LaskutusRyhmaMayhem
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Servicewindow : Window
    {
        public Servicewindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       

      

        private void Enterprise_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FreeTrial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Basic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combobox.SelectedItem != null)
            {
                //ComboBoxItem cbi1 = (ComboBoxItem)(sender as ComboBox).SelectedItem;  
                ComboBoxItem cbi = (ComboBoxItem)combobox.SelectedItem;
                string v = cbi.Content.ToString();
            }
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    }


