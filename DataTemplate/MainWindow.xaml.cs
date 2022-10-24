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

        static DAL dal = new();                                                                     //her laves der et static field som bruges til at alt og alle kan tilgå vores "DAL" (altså vores database)

        public ObservableCollection<Person> Personer { get; set; } = dal.Get();                     // her laves der noget jeg ikke kan huske!!
                                                                                                    // Men den gør så vi samler dataen fra vores database
                                                                                                    // Og bruger den til vores nye ting der hedder pesoner 


        public MainWindow()                                                                         //aner ikke hvad det skal betyde!!!!! 
        {
            
            //Her fortæller vi vores XAML hvor det kan finde den data der skal bindes op imod.
            DataContext = this; 
            InitializeComponent();
        }

        // Her bliver der lavet en button som tager værdierne der er tastet ind i textboxene
        // Og laver en ny person ud af det
        private void btn_insert_Click(object sender, RoutedEventArgs e)
        {
            int id = Personer.Count + 1;                                                            // Her deklarere den hvad ID'en skal være ud fra hvor mange der er i personerlisten
            Person person = new(id, tb_fornavn.Text, tb_efternavn.Text, int.Parse(tb_formue.Text)); // Her får den nye person deres værdier/oplysninger
            dal.Insert(person);                                                                     // Her fortæller den hvordan den nye person skal stilles op
            Personer = dal.Get();                                                                   // Her opdatere den brugersiden da den ikke sel gør det/eller er live

        }


        /// <summary>
        /// Her kan man obdatere en valgfri person, ved hjælp af deres ID nummer.
        /// Først laves der en ny person
        /// herefter bruger vi funktionen som tjekker alle personers ID
        /// den prøver så og machte med det nummer der er skrevet ind i tb_IDNummer.text med en af de personer på listen
        /// og returnere den valgte persons værdi
        /// Nu kan vi bruge personenes værdi lave alt det vi vil med den (i dette tilfælde du vi nu skriver i de andre tekstboke)
        /// </summary>
        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            Person person = dal.GetById(int.Parse(tb_IDNummer.Text));

            person.Fornavn = tb_fornavn.Text;
            person.Efternavn = tb_efternavn.Text;
            person.Formue = int.Parse(tb_formue.Text);
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
           Personer.Remove(Personer[dg_personer.SelectedIndex]);                                   //fra personer listen fjernes der den person som bliver valgt i datagridden 
            
        }
    }
}
