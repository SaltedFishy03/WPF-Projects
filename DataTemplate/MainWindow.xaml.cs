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

namespace DataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static DAL dal = new();

        public ObservableCollection<Person> Personer { get; set; } = dal.Get();

        public MainWindow()
        {
            //Personer = dal.Get();
            DataContext = this;
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, RoutedEventArgs e)
        {
            
            Person person = new(1, tb_fornavn.Text, tb_efternavn.Text, int.Parse(tb_formue.Text));
            dal.Insert(person);
            Personer = dal.Get();

        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
           Personer.Remove(Personer[dg_personer.SelectedIndex]);           //fra personer listen fjernes der den person som bliver valgt i datagridden 
            
        }
    }
}
