using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_app
{
    public class Pizzaer
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public int Price { get; set; }   

        public Pizzaer(string _name, string _desciption, int _price)
        {
           Name = _name;
           Description = _desciption; 
           Price = _price;
         
            
        }
    }
}
