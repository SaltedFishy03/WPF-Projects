using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace pizza_app.database
{
    public partial class DAL
    {
        public ObservableCollection<Toppings> ToppingList { get; set; } = new();

        public ObservableCollection<Pizzaer> PizzaList { get; set; } = new();

        public ObservableCollection<Sides> SidesList { get; set; } = new();
        public ObservableCollection<SidesSize> SideSizeList { get; set; } = new();

        public ObservableCollection<SidesSize> DrinksList { get; set; } = new();

        public DAL()
        {
            ToppingList = new ObservableCollection<Toppings>
            {
                new Toppings(1, " Tomatsauce", 5),
                new Toppings(2, " Ost", 5),
                new Toppings(3, " Peperoni", 5),
                new Toppings(4, " Skinke", 5),
                new Toppings(5, " Oskekød", 5),
                new Toppings(6, " Kebab", 10),
                new Toppings(7, " Ananas", 5),
                new Toppings(8, " Salat", 10),
                new Toppings(9, " Hjemmelavet dressing", 5)
            };



            PizzaList = new ObservableCollection<Pizzaer>
            {
                new Pizzaer(1, "Magaritta", $"Dette er vores ostepizza, med", new ObservableCollection<Toppings> { ToppingList[0], ToppingList[1] }, 50),
                new Pizzaer(2, "Peperoni", $"dettte er vores klasike peperonipizza, med", new ObservableCollection<Toppings> { ToppingList[0], ToppingList[2], ToppingList[1] }, 50),
                new Pizzaer(3, "Ham", $"Dette er vores skinkepizza, med", new ObservableCollection<Toppings> { ToppingList[0], ToppingList[3], ToppingList[1] }, 50),
                new Pizzaer(4, "Hawaii", $"Dette er vores Hawaiipizza, med", new ObservableCollection<Toppings> { ToppingList[0], ToppingList[3], ToppingList[6], ToppingList[1] }, 10),
                new Pizzaer(5, "Salatpizza", $"Dette er vores salatpiizza, med", new ObservableCollection<Toppings> { ToppingList[0], ToppingList[4], ToppingList[1], ToppingList[7], ToppingList[8] }, 50),
                new Pizzaer(6, "Kebabpizza", $"Dette er vores kebabpizza, med", new ObservableCollection<Toppings> { ToppingList[0], ToppingList[5], ToppingList[1] }, 50)
            };

            DrinksList = new ObservableCollection<SidesSize>
            {
                new SidesSize("Lille", 15),
                new SidesSize("Mellem", 20),
                new SidesSize("Stor", 25)
            };

            SideSizeList = new ObservableCollection<SidesSize>
            {
                new SidesSize("Lille", 20),
                new SidesSize("Mellem", 25),
                new SidesSize("Stor", 30)
            };

            SidesList = new ObservableCollection<Sides>
            {
                new Sides(1, "Cola", "Vælg flere forskellige størelser", DrinksList),
                new Sides(2, "Pommes", "Vælg flere forskellige størelser", SideSizeList)
            };

        }


        //public ObservableCollection<Pizzaer> Get()
        //{
        //    _PublicListe.Clear();

        //    foreach (Pizzaer p in PizzaList)
        //    {
        //        _PublicListe.Add(p);
        //    }

        //    return _PublicListe;
        //}

        //public void Commit()
        //{
        //    PizzaList = new ObservableCollection<Pizzaer>(_PublicListe);
        //}


    }
}

