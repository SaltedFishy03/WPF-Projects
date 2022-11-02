using CommunityToolkit.Mvvm.ComponentModel;
using pizza_app.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
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


        public MainWindowViewModel()
        {
            DAL d = new DAL();
            foreach (var p in d.PizzaList)
            {
                Orders.Add(new Order(p));
            }

            foreach (var s in d.SidesList)
            {
                SideOrder.Add(new Order(s));
            }

            
            //foreach (var s in d.SidesList)
            //{
            //    Orders.Add(new Order(s));
            //}
        }
    }
}
