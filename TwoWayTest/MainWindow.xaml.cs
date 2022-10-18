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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TwoWayTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person(0, "send", "bendt", 100);
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
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
    }
}
