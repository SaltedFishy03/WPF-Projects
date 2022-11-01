using pizza_app.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_app.ViewModels
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();

        public MainWindowViewModel()
        {
            DAL d = new DAL();
            foreach (var p in d.PizzaList)
            {
                Orders.Add(new Order(p));
            }
        }
    }
}
