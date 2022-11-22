﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace pizza_app
{

    public class Order
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }


        public Order(Pizzaer pizza)
        {
            ID = pizza.ID;
            Name = pizza.Name;
            Description = pizza.Description;
            Price = pizza.Price;

            foreach (var toppping in pizza.Topping)
            {
                Description += toppping.Name;
                Price += toppping.Price;

            }


        }
        public Order(Sides side)
        {
            ID = side.ID;
            Name = side.Name;
            Description = side.Description;
            Price = side.Price;
        }

        public Order(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}