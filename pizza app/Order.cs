using CommunityToolkit.Mvvm.ComponentModel;
using pizza_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace pizza_app
{

    public partial class Order : ObservableObject
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [ObservableProperty] private double _price;
        public ObservableCollection<SidesSize> Size { get; set; }

        private Pizzaer _pizza;

        public ObservableCollection<Toppings> Topping { get; set; } = new();




        public Order DeepCopy(Pizzaer pizza)
        {
            Order PizzaCopy = new Order(ID, Name, Description, new ObservableCollection<Toppings>(Topping), Price);
            ID = PizzaCopy.ID;
            Name = PizzaCopy.Name;
            Description = PizzaCopy.Description;
            Price = PizzaCopy.Price;

            foreach (var toppping in PizzaCopy.Topping)
            {
                Description += toppping.Name;
                Price += toppping.Price;

            }
            PropertyChanged += Pizza_PropertyChanged;

            return PizzaCopy;

        }




        //public Order(Pizzaer pizza)
        //{
        //    _pizza = new Pizzaer(pizza.ID, pizza.Name, pizza.Description, new ObservableCollection<Toppings>(pizza.Topping), pizza.Price);
        //    ID = pizza.ID;
        //    Name = pizza.Name;
        //    Description = pizza.Description;
        //    Price = 50;


        //    foreach (var toppping in pizza.Topping)
        //    {
        //        Description += toppping.Name;
        //        Price += toppping.Price;

        //    }
        //    pizza.PropertyChanged += Pizza_PropertyChanged;

        //}

        private void Pizza_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _pizza.Price = Price;

        }

        public Order(Sides side)
        {
            ID = side.ID;
            Name = side.Name;
            Description = side.Description;
            Price = side.Price;
            Size = side.Sizes;
        }

        public Order(string name, string destription, double price)
        {
            Name = name;
            Price = price;
            Description = destription;
        }

        private Order(int _id, string _name, string _destription, ObservableCollection<Toppings> _toppings, double _price)
        {
            ID = _id;
            Name = _name;
            Description = _destription;
            Topping = _toppings;
            Price = _price;
        }


    }
}