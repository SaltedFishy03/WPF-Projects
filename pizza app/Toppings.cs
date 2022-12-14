using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pizza_app
{
    public class Toppings
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Toppings(int _id, string _name, double _price)
        {
            ID = _id;
            Name = _name;
            Price = _price;
        }

        public object Clone()
        {
            Toppings t = new(ID, Name, Price);
            return t;
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