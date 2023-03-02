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
            combobox.Items.Add("Basic");
            combobox.Items.Add("Pro");
            combobox.Items.Add("Enterprise");
            combobox.Items.Add("Freetrial");

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }




    private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        
    }
    }


