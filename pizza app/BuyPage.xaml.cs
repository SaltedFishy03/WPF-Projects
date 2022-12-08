using pizza_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace pizza_app
{
    /// <summary>
    /// Interaction logic for BuyPage.xaml
    /// </summary>
    public partial class BuyPage : Window
    {
        BuyViewModel bvm = new();

        public BuyPage()
        {
            InitializeComponent();
            DataContext = bvm;
        }

        private void DeleteFunktion(object sender, MouseButtonEventArgs e)
        {

        }

        private void btn_payment_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
