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
        [ObservableProperty] private ObservableCollection<Toppings> _toppinglist;

        [ObservableProperty] private ObservableCollection<Pizzaer>? _pizzaList;

        [ObservableProperty] private ObservableCollection<Sides> _sidesList;




        public DAL()
        {
            Toppinglist = new ObservableCollection<Toppings>();
            Toppinglist.Add(new Toppings(1, " Tomatsauce", 5));
            Toppinglist.Add(new Toppings(2, ", Ost", 5));
            Toppinglist.Add(new Toppings(3, ", Peperoni", 5));
            Toppinglist.Add(new Toppings(4, ", Skinke", 5));
            Toppinglist.Add(new Toppings(5, ", Oskekød", 5));
            Toppinglist.Add(new Toppings(6, ", Kebab", 10));
            Toppinglist.Add(new Toppings(7, ", Ananas", 5));
            Toppinglist.Add(new Toppings(8, ", Salat", 10));
            Toppinglist.Add(new Toppings(9, ", Hjemmelavet dressing", 5));







            PizzaList = new ObservableCollection<Pizzaer>();
            PizzaList.Add(new Pizzaer(1, "Magaritta",$"Dette er vores ostepizza, med",new ObservableCollection<Toppings> {Toppinglist[0], Toppinglist[1]}, 50));
            PizzaList.Add(new Pizzaer(2, "peperoni", $"dettte er vores klasike peperonipizza, med", new ObservableCollection<Toppings> {Toppinglist[0], Toppinglist[2], Toppinglist[1] }, 50));
            PizzaList.Add(new Pizzaer(3, "Ham", $"Dette er vores skinkepizza, med", new ObservableCollection<Toppings> {Toppinglist[0], Toppinglist[3], Toppinglist[1]}, 50));
            PizzaList.Add(new Pizzaer(4, "Hawaii", $"Dette er vores Hawaiipizza, med", new ObservableCollection<Toppings> {Toppinglist[0], Toppinglist[3], Toppinglist[6], Toppinglist[1]}, 10));
            PizzaList.Add(new Pizzaer(5, "Salatpizza", $"Dette er vores salatpiizza, med", new ObservableCollection<Toppings> { Toppinglist[0], Toppinglist[4], Toppinglist[1], Toppinglist[7], Toppinglist[8]}, 60));
            PizzaList.Add(new Pizzaer(6, "kebabpizza", $"Dette er vores kebabpizza, med", new ObservableCollection<Toppings>{Toppinglist[0], Toppinglist[5], Toppinglist[1]}, 60));

            SidesList = new ObservableCollection<Sides>();
            SidesList.Add(new Sides(1, "Drikkelse", "Sodavand i flere varianter", 25));
            SidesList.Add(new Sides(2, "Pommes", "Pomfritter med salt og døbbelse", 25));
            SidesList.Add(new Sides(3, "7 Nuggets", "hjemmelavet nuggets", 30));


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

