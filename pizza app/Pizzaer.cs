using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml;

namespace pizza_app
{
    public partial class Pizzaer : ObservableObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public ObservableCollection<Toppings> Topping { get; set; }

        [ObservableProperty] double _price;

        public Pizzaer(int _id, string _name, string _desciption, ObservableCollection<Toppings> _topping, double _price)
        {
            ID = _id;
            Name = _name;
            Description = _desciption;
            Topping = _topping;
            Price = _price;

            //foreach (var topping in Topping)
            //{
            //    Description += topping.Name;
            //    Price += topping.Price;

            //}
        }

        public object Clone()
        {
            Pizzaer p = new(ID, Name, Description, Topping, Price);
            return p;
        }
    }

}

