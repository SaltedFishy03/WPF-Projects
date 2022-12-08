using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_app
{
    public class SidesSize
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public SidesSize(string _name, double _price)
        {
            Price = _price;
            Name = _name;
        }
        //public SidesSize(SidesSize s)
        //{
        //    Price = s.Price;
        //    Name = s.Name;
        //}
    }
}
