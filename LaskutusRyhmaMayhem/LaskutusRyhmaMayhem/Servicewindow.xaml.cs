using System;
using System.Collections.Generic;
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
            textbox.Text = combobox.SelectedItem.ToString();
        }




    private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBox1.Text = ComboBox1.SelectedItem.ToString();
            
        }
    }
    }


