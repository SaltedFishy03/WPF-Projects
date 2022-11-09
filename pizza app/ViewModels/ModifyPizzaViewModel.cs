using pizza_app.database;
using System.Collections.ObjectModel;

namespace pizza_app.ViewModels
{
    public class ModifyPizzaViewModel
    {
        public Pizzaer Pizza { get; set; }
        private DAL dal = new DAL();
        public ObservableCollection<Toppings> ToppingList { get; set; }
        public ModifyPizzaViewModel(Pizzaer pizza)
        {
            ToppingList = dal.ToppingList;
            Pizza = pizza;
        }
    }
}