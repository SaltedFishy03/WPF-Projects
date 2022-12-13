using CommunityToolkit.Mvvm.ComponentModel;
using pizza_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace pizza_app
{

    public partial class Order : ObservableObject, ICloneable
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [ObservableProperty] double _price;
        public ObservableCollection<SidesSize> Size { get; set; }

        public ObservableCollection<Toppings> Topping { get; set; } = new();



        public Order(Pizzaer PizzaCopy)
        {

            //ID = p.ID;
            //Name = p.Name;
            //Description = p.Description;
            //Price = p.Price;



            ID = PizzaCopy.ID;
            Name = PizzaCopy.Name;
            Description = PizzaCopy.Description;
            Price = 50;



            foreach (var toppping in PizzaCopy.Topping)
            {
                Topping.Add(toppping);
                Description += toppping.Name;
                Price += toppping.Price;

            }

        }


        public object Clone()
        {
            ObservableCollection<Toppings> DeepCopyList(ObservableCollection<Toppings> a)
            {
                ObservableCollection<Toppings> t = new();

                foreach (var item in t)
                {
                    t.Add((Toppings)item.Clone());
                }
                return t;
            }
            Order c = new(ID, Name, Description, Topping, Price);
            return c;
        }

        #region commented
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

        #endregion


        #region Constructors
        public Order(Sides side)
        {

            ID = side.ID;
            Name = side.Name;
            Description = side.Description;
            Price = side.Price;
            Size = side.Sizes;
        }

        public Order(int id, string name, string destription, double price)
        {
            ID = id;
            Name = name;
            Price = price;
            Description = destription;
        }

        public Order(int _id, string _name, string _destription, ObservableCollection<Toppings> _toppings, double _price)
        {
            ID = _id;
            Name = _name;
            Description = _destription;
            Topping = _toppings;
            Price = _price;
        }
        #endregion


    }
}