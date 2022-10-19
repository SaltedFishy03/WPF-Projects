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

namespace TwoWayTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        ObservableCollection<Person> Personer = new ObservableCollection<Person>();

        Person person = new Person(0, "svend", "bendt", 100);
        public MainWindow()
        {
            InitializeComponent();
  
            Personer.Add(person);
            Personer.Add(new Person(0, "Bein", "Stagge", -987654321));
            Personer.Add(new Person(1, "Turt", "Khorsen", 0));
            Personer.Add(new Person(2, "Gill", "Bates", int.MaxValue));
            this.DataContext = Personer;
        }
        private void btn_data_Click(object sender, RoutedEventArgs e)
        {
            string PersonData = person.Fornavn +
                " " +
                person.Efternavn +
                " har en formue på " +
                person.Formue +
                " Kr ";

            MessageBox.Show(PersonData);
        }


        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            int tal = person.Formue;
            tal++;
            person.Formue = tal;

            string nyNavn = person.Fornavn;

            nyNavn = "mathias";

           person.Fornavn = nyNavn;

            string nyEfternavn = person.Efternavn;

            nyEfternavn = "schaltz";

            person.Efternavn = nyEfternavn;
        }
    }
}
