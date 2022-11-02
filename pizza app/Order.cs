using System;
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


        public Order(Pizzaer p)
        {
            ID = p.ID;
            Name = p.Name;
            Description = p.Description;
            Price = p.Price;

            foreach (var t in p.Topping)
            {
                Description += t.Name;
                Price += t.Price;

            }


        }
        public Order(Sides s)
        {
            ID = s.ID;
            Name = s.Name;
            Description = s.Description;
            Price = s.Price;
        }
    }
}