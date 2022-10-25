using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace pizza_app.database
{
    public partial class DAL : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<Pizzaer>? _pizzaList;


        [ObservableProperty] private ObservableCollection<Tilbehør> _sidesList;

        [ObservableProperty] private ObservableCollection<Pizzaer>? _basket;


        public DAL()
        {
            PizzaList = new ObservableCollection<Pizzaer>();
            PizzaList.Add(new Pizzaer("Magaritta","Tomatosauce, Cheese", 50));
            PizzaList.Add(new Pizzaer("pepperoni","Tomatosauce, Pepperoni, Chesse", 50));
            PizzaList.Add(new Pizzaer("Ham","Tomatosauce, Ham, Cheese", 50));
            PizzaList.Add(new Pizzaer("Hawaii","Tomatosause, Ham, Pineable, Cheese", 10));
            PizzaList.Add(new Pizzaer("Salatpizza", "Tomatosauce, Beef, Lettuce, Homemade resseing", 60));
            PizzaList.Add(new Pizzaer("kebabpizza","Tomatosauce, kebab, cheese", 60));

            SidesList = new ObservableCollection<Tilbehør>();
            SidesList.Add(new Tilbehør("Drink", 25));
            SidesList.Add(new Tilbehør("Fries", 25));
            SidesList.Add(new Tilbehør("7 Nuggets", 30));

            Basket = new ObservableCollection<Pizzaer>();
            Basket.Add(new Pizzaer("1", "1", 1));
            

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

