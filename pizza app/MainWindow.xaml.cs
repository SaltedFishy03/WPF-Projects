using System;
using System.Collections.ObjectModel;
using System.Linq;
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


        }

        private void btn_buy_Click(object sender, RoutedEventArgs e)
        {
            BuyPage PayWindow = new();
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
                                //foreach (var p in dal.PizzaList)
                                //{
                                //    if (p.ID == o.ID)
                                //    {
                                //        pizza = p;
                                //    }
                                //}


                                ModifyPizza ModifyWindow = new(o.Clone() as Order);
                                if (ModifyWindow.ShowDialog() == true)
                                {

                                    var t = mvm.Basket.Where(p => p.ID == o.ID).FirstOrDefault();

                                    //Order t = null;
                                    //foreach (var item in mvm.Basket)
                                    //{
                                    //    if (item.ID == o.ID)
                                    //    {
                                    //        t = o; 
                                    //        break;
                                    //    }
                                    //}

                                    if (t != null)
                                    {
                                        mvm.Basket.Remove(t);
                                        mvm.Basket.Add(ModifyWindow.pizza);
                                    }
                                }

                                break;

                            case MessageBoxResult.No:
                                mvm.Basket.Remove(o);
                                MessageBox.Show("Du har nu fjernet " + o.Name, "Fjen" + o.Name, MessageBoxButton.OK, MessageBoxImage.Information);
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
                                MessageBox.Show("Du har nu fjernet " + o.Name, "Fjern" + o.Name, MessageBoxButton.OK, MessageBoxImage.Information);
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

