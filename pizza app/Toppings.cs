using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pizza_app
{
    public class Topping
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Topping(string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }
    }

    //public enum Toppings
    //{
    //    Cheese,
    //    Tomatosauce,
    //    Pepperoni,
    //    Ham,
    //    Beef,
    //    Kebab,
    //    Onions,
    //    Lettuce,
    //    Olives,
    //    pineable
    //}
}
