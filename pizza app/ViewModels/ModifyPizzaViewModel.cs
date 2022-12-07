using CommunityToolkit.Mvvm.ComponentModel;
using pizza_app.database;
using System.Collections.ObjectModel;
using System.Reflection.Emit;

namespace pizza_app.ViewModels
{
    public partial class ModifyPizzaViewModel : ObservableObject
    {
        [ObservableProperty] public Pizzaer _customPizza;
        public DAL dal = new DAL();

        public ObservableCollection<Toppings> CustomToppings { get; set; }

        public ModifyPizzaViewModel(Pizzaer pizza)
        {
            CustomToppings = dal.ToppingList;
            CustomPizza = pizza;
        }


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