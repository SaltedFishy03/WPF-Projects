using CommunityToolkit.Mvvm.ComponentModel;
using pizza_app.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pizza_app.ViewModels
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
        public ObservableCollection<Order> SideOrder { get; set; } = new ObservableCollection<Order>();
        public ObservableCollection<Order> Basket { get; set; } = new ObservableCollection<Order>();
        public ObservableCollection<Order> CustomPizza { get; set; } = new ObservableCollection<Order>();


        public MainWindowViewModel()
        {
            DAL dal = new DAL();
            foreach (var pizza in dal.PizzaList)
            {
                Orders.Add(new Order(pizza));
            }

            foreach (var sides in dal.SidesList)
            {
                SideOrder.Add(new Order(sides));
            }


            
            //foreach (var s in d.SidesList)
            //{
            //    Orders.Add(new Order(s));
            //}
        }
    }
}
