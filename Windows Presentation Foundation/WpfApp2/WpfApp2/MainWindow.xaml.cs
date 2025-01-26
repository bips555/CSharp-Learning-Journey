using System;
using System.Collections.Generic;
using System.Configuration;
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
using WpfApp2.Properties;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["WpfApp2.Properties.Settings.BIPSDBREVISIONConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(cs);
            InsertUniversity();
        }
        public void InsertUniversity()
        {
           
            University KU = new University();
            KU.Name = "KU";

            University TU = new University();
            KU.Name = "TU";

            dataContext.Universities.InsertOnSubmit(TU);
            dataContext.Universities.InsertOnSubmit(KU);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }
    }
   
}
