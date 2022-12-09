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
        MainWindowViewModel mvm = new();

        public BuyPage()
        {
            InitializeComponent();
            DataContext = bvm;
        }

        private void DeleteFunktion(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Har du lyst til at fjerne denne bestilling", "Fjern en bestilling", MessageBoxButton.YesNo);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    mvm.Basket.Remove(mvm.Basket[lb_bestilling.SelectedIndex]);
                    bvm.Buy.Remove(bvm.Buy[lb_bestilling.SelectedIndex]);
                    break;

                case MessageBoxResult.No:
                    break;
            }
        }

        private void btn_payment_Click(object sender, RoutedEventArgs e)
        {
            string allPurchases = string.Empty;
            foreach (var item in bvm.Buy)
            {
                allPurchases += $", {item.Name}";
            }

            MessageBox.Show("Du har nu købt" + allPurchases, "Dit køb", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
