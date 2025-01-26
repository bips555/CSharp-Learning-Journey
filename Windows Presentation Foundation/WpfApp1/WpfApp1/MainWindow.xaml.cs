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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Sum SumObj {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            SumObj = new Sum { Num1 = "1",Num2 = "3"};
            this.DataContext = SumObj;  
            
          /*  MySlider.Value = 40;
            MyTextBox.Text = MySlider.Value.ToString();*/


           /* Grid grid = new Grid(); 
            this.Content = grid;
            Button btn = new Button();
            btn.FontSize = 12;
            btn.Height = 120;
            btn.Width = 200;
            WrapPanel wp = new WrapPanel();
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Multi";
            textBlock.Foreground = Brushes.AliceBlue;

            TextBlock textBlock1 = new TextBlock();
            textBlock1.Text = "Color";
            textBlock1.Foreground = Brushes.Red;

            TextBlock textBlock2 = new TextBlock();
            textBlock2.Text = "Button";
            textBlock2.Foreground = Brushes.White;

            wp.Children.Add(textBlock);
            wp.Children.Add(textBlock1);
            wp.Children.Add(textBlock2);

            btn.Content = wp;

            grid.Children.Add(btn);*/


        }

       /* private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for clicking me");
        }
*/
        /*private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Thanks for clicking me");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Thanks for clicking me");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Thanks for clicking me");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Thanks for clicking me");
        }*/
    }

}
