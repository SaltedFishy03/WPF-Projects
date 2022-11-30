using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_app
{
    public class Sides
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public ObservableCollection<SidesSize> Sizes { get; set; }

        public Sides(int _id, string _name, string _description, ObservableCollection<SidesSize> size)
        {
            ID = _id;
            Name = _name;
            Description = _description;
            Sizes = size;

        }
    }

}
