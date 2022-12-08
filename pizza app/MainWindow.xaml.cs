﻿using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using pizza_app.database;
using pizza_app.ViewModels;

namespace pizza_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DAL dal = new();
        MainWindowViewModel mvm = new();
        BuyViewModel bvm = new();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;

            Uri iconUri = new Uri("https://media-exp1.licdn.com/dms/image/C4D03AQGXi3dwJ0rDCQ/profile-displayphoto-shrink_800_800/0/1651108360106?e=1674691200&v=beta&t=OFxipBWQAOBP2OhysdJUHwVaxz1N7G-FlSTVrcoRDEI", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
        }

        private void btn_buy_Click(object sender, RoutedEventArgs e)
        {

            BuyPage PayWindow = new BuyPage();
            PayWindow.ShowDialog();

        }

        private void lb_pizza_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Order o = new Order(dal.PizzaList[lb_pizza.SelectedIndex]).Clone() as Order;
            mvm.Basket.Add(o);

            //MessageBox.Show($"{o.GetHashCode()}");
        }

        private void SidesSizeChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox? c = sender as ComboBox;
            if (c.Tag is Order o)
            {
                if (c.SelectedValue is SidesSize s)
                {
                    mvm.Basket.Add(new Order(o.ID, o.Name, string.Empty, s.Price));

                }
            }
        }

        private void lb_basket_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Sides side = null;
            Pizzaer pizza = null;
            ListBoxItem? l = sender as ListBoxItem;

            foreach (var s in dal.SidesList)
            {

                side = s;
            }
            if (l != null)
            {
                if (l.Tag is Order o)
                {


                    if (o.ID != side.ID)
                    {
                        MessageBoxResult result = MessageBox.Show("Tryk ja for at modificere din pizza og nej for at slette den. \n\nFor at fortryde tryk på anuller", "Modificer " + o.Name, MessageBoxButton.YesNoCancel);
                        switch (result)
                        {
                            case MessageBoxResult.Yes:
                                foreach (var p in dal.PizzaList)
                                {
                                    if (p.ID == o.ID)
                                    {
                                        pizza = p;
                                    }
                                }

                                ModifyPizza ModifyWindow = new(pizza);
                                if (ModifyWindow.ShowDialog() == true)
                                {
                                    mvm.Basket.Add((ModifyWindow.pizza.Clone() as Order));
                                }
                                break;

                            case MessageBoxResult.No:
                                mvm.Basket.Remove(o);
                                MessageBox.Show("Du har nu fjernet " + o.Name);
                                break;

                            case MessageBoxResult.Cancel:
                                break;
                        }
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Har du lyst til at fjerne " + o.Name, "Fjern " + o.Name, MessageBoxButton.YesNo);
                        switch (result)
                        {

                            case MessageBoxResult.Yes:
                                mvm.Basket.Remove(o);
                                MessageBox.Show("Du har nu fjernet " + o.Name);
                                break;

                            case MessageBoxResult.No:
                                break;
                        }

                    }
                }
            }
        }


    }
}

