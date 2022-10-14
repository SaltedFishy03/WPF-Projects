using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace BingoGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> InPlayNumbers = new();
        ObservableCollection<int> UsedNumbers = new();


        public MainWindow()
        {
            InitializeComponent();
            lb_unUsedNumbers.ItemsSource = InPlayNumbers;
            lb_usedNumbers.ItemsSource = UsedNumbers;

            for (int i = 1; i < 91; i++)
            {
                InPlayNumbers.Add(i);
                
            }
        }
        private void btn_pullNumber_Click(object sender, RoutedEventArgs e)
        {
            var random = new Random();
            int pull = random.Next(1, 91);
            l_currentNumber.Content = pull;
            UsedNumbers.Add(pull);
            InPlayNumbers.RemoveAt(pull);
        }
    }
}
