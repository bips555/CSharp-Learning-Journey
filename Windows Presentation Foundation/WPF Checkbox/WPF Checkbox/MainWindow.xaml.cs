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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Checkbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void IsAllChecked(object sender,RoutedEventArgs e)
        {
            bool newVal = (PizzaToppings.IsChecked == true);
            Mushroom.IsChecked = newVal;
            Mozarella.IsChecked = newVal;
            Salami.IsChecked = newVal;

        }
        private void IsSingleChecked(object sender, RoutedEventArgs e)
        {
            PizzaToppings.IsChecked = null;
            if((Salami.IsChecked == true) && (Mozarella.IsChecked == true) && (Mushroom.IsChecked == true))
            {
                PizzaToppings.IsChecked = true;
            }
            else if((Salami.IsChecked == false) && (Mozarella.IsChecked == false) && (Mushroom.IsChecked == false))
            {
                PizzaToppings.IsChecked = false;
            }
        }
    }
}
