using pizza_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pizza_app
{
    /// <summary>
    /// Interaction logic for ModifyPizza.xaml
    /// </summary>
    public partial class ModifyPizza : Window
    {
       
        MainWindowViewModel mvm = new MainWindowViewModel();
        private Order o;

    

        public ModifyPizza(Order o)
        {
            this.o = o;
            InitializeComponent();
            DataContext = o;
        }
    }
}
