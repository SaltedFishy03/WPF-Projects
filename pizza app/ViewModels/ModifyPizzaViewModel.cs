﻿using CommunityToolkit.Mvvm.ComponentModel;
using pizza_app.database;
using System.Collections.ObjectModel;
using System.Reflection.Emit;

namespace pizza_app.ViewModels
{
    public partial class ModifyPizzaViewModel : ObservableObject
    {
        [ObservableProperty] private Pizzaer _customPizza;
        private DAL dal = new DAL();

        public ObservableCollection<Toppings> CustomToppings { get; set; }

        //[ObservableProperty] private Sides _customSide;

        //public ObservableCollection<Toppings> CustomSize { get; set; }

        public ModifyPizzaViewModel(Pizzaer pizza)
        {
            CustomToppings = dal.ToppingList;
            CustomPizza = pizza;
        }

        //public ModifyPizzaViewModel(Sides side)
        //{
        //    CustomSide= side;
        //}

        
        public void GetCustomPrice()
        {
           
            double toppingsPrice = 0;
            foreach (var item in CustomPizza.Topping)
            {
                toppingsPrice += item.Price;
            }

            CustomPizza.Price = toppingsPrice + 50;
        }
    }
}