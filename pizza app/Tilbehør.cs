using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_app
{
    public class Tilbehør
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public Tilbehør(string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }
    }

}
