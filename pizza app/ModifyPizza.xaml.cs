﻿using pizza_app.database;
using pizza_app.ViewModels;
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

namespace pizza_app
{
    /// <summary>
    /// Interaction logic for ModifyPizza.xaml
    /// </summary>
    public partial class ModifyPizza : Window
    {

        MainWindowViewModel mvm = new MainWindowViewModel();
        private Order o;
        private Pizzaer pizza;
        private ModifyPizzaViewModel vm;
        public DAL dal = new DAL();

        public ModifyPizza(Pizzaer Pizza)
        {
            pizza = Pizza;
            vm = new ModifyPizzaViewModel(pizza);
            InitializeComponent();
            vm.GetCustomPrice();

            DataContext = vm;
        }

        private void lb_topping_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            vm.CustomPizza.Topping.Add(new Toppings(dal.ToppingList[lb_topping.SelectedIndex].ID, dal.ToppingList[lb_topping.SelectedIndex].Name, dal.ToppingList[lb_topping.SelectedIndex].Price));

            vm.GetCustomPrice();

        }

        private void lb_pizza_topping_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            vm.CustomPizza.Topping.Remove(vm.CustomPizza.Topping[lb_pizza_topping.SelectedIndex]);

            vm.GetCustomPrice();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
