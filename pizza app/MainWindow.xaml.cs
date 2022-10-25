using CommunityToolkit.Mvvm.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using pizza_app.database;

namespace pizza_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DAL dal = new();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = dal;

        }

        private void btn_buy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lb_pizza_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            dal.Basket.Add(new Pizzaer((dal.PizzaList[lb_pizza.SelectedIndex].Name), (dal.PizzaList[lb_pizza.SelectedIndex].Description), (dal.PizzaList[lb_pizza.SelectedIndex].Price)));

        }
    }
}
