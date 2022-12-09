using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace pizza_app.ViewModels
{
    public class BuyViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Order> _buy = new();
        public ObservableCollection<Order> Buy
        {
            get { return _buy; }
            set { _buy = value; OnPropertyChanged("Buy"); }
        }

        public BuyViewModel()
        {
            MainWindowViewModel mvm = new();

            for (int i = 0; i < mvm.Basket.Count; i++)
            {
                Buy.Add(mvm.Basket[i]);
            }

        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
