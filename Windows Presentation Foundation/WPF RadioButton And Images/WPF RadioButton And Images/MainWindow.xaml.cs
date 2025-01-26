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

namespace WPF_RadioButton_And_Images
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbMaybe.IsChecked = true;
        }

        private void RadioButton_Click_Yes(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yes , Thank you");
        }
        private void RadioButton_Click_Maybe(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Maybe Haha");
        }
        private void RadioButton_Click_No(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("No thanks.");
        }
    }

}
