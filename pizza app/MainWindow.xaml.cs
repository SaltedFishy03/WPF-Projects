﻿using CommunityToolkit.Mvvm.ComponentModel;
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
using pizza_app.ViewModels;

namespace pizza_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static DAL dal = new();
        MainWindowViewModel mvm = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;

        }

        private void btn_buy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lb_pizza_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            mvm.Basket.Add(new Order(dal.PizzaList[lb_pizza.SelectedIndex]));




            // mvm.Baskett.Add(new Order(dal.PizzaList[lb_pizza.SelectedIndex].ID, dal.PizzaList[lb_pizza.SelectedIndex].Name, dal.PizzaList[lb_pizza.SelectedIndex].Description, 
            //   dal.PizzaList[lb_pizza.SelectedIndex].Topping, dal.PizzaList[lb_pizza.SelectedIndex].Price));

        }
        private void lb_sides_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            mvm.Basket.Add(new Order(dal.SidesList[lb_sides.SelectedIndex]));

            // dal.SideBakset.Add(new Sides(dal.SidesList[lb_sides.SelectedIndex].ID, dal.SidesList[lb_sides.SelectedIndex].Name, dal.SidesList[lb_sides.SelectedIndex].Description, dal.SidesList[lb_sides.SelectedIndex].Price));

        }

        private void lb_basket_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem l = sender as ListBoxItem;
            if (l != null)
            {
                Order o = l.Tag as Order;
                if (o != null)
                {

                    MessageBoxResult result = MessageBox.Show("Tryk ja for at modificere din pizza og nej for at slette den. \n\nFor at fortryde tryk på anuller", "Modificer " + o.Name, MessageBoxButton.YesNoCancel);
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            //mvm.CustomPizza.Add(new Order(dal.PizzaList[this.lb_basket.SelectedIndex]));
                            ModifyPizza ModifyWindow = new ModifyPizza(o);
                            ModifyWindow.ShowDialog();
                            break;
                        case MessageBoxResult.No:
                            mvm.Basket.Remove(o);
                            MessageBox.Show("Du har nu fjernet " + o.Name);
                            break;
                        case MessageBoxResult.Cancel:
                            break;
                    }

                }
            }
        }
    }
}
