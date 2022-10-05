using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lille_lommeregner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regnetegn regnetegn;
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dette er en enum der definere de oprindelige regnetegn (altså tjekker om det er det rigtige tegn vi vil bruge)
        /// </summary>
        enum Regnetegn
        {
            Plus,
            Minus,
            Divider,
            Gange
        }

        /// <summary>
        /// spørg en
        /// </summary>
        private void plus_click(object sender, RoutedEventArgs e)
        {
            symbol.Text = btn_plus.Content.ToString();
            tb_resultat.Text = RegneFunktion(Regnetegn.Plus).ToString();
        }

        private void minus_click(object sender, RoutedEventArgs e)
        {
            symbol.Text = btn_minus.Content.ToString();
            tb_resultat.Text = RegneFunktion(Regnetegn.Minus).ToString();

        }

        private void gange_click(object sender, RoutedEventArgs e)
        {
            symbol.Text = btn_gange.Content.ToString();
            tb_resultat.Text = RegneFunktion(Regnetegn.Gange).ToString();
        }

        private void division_click(object sender, RoutedEventArgs e)
        {
            symbol.Text = btn_division.Content.ToString();
            tb_resultat.Text = RegneFunktion(Regnetegn.Divider).ToString();

        }
        private double RegneFunktion(Regnetegn regnetegn)
        {

            double tal1 = 0;
            double tal2 = 0;
            double resultat = 0;
            
            /// <summary>
            /// Try tjekker om tal 1 og tal 2 er et tal (altså prøver og at cenventere tal 1 og 2 til double fra string. 
            /// </summary>
            try
            {
                tal1 = Convert.ToDouble(tb_tal1.Text);
                tal2 = Convert.ToDouble(tb_tal2.Text);
            }

            ///<summary>
            /// Catch bruger vi tal at fange forventet fejl når vi bruger Exception.
            /// </summary>
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "hov...");
            }

            ///<summary>
            /// Switchen her bruger vi tal at tjekke hvilket tegn vi vil bruge. 
            /// For at tjekke det køre den alle case's med forskellige tegn igennem indtil den finder det rigtige tegn. 
            /// Hvor den så derefter køre koden i case'en og retunere resultatet
            /// </summary>
            switch (regnetegn)
            {
                case Regnetegn.Plus:
                    return resultat = tal2 + tal1 ;
                case Regnetegn.Minus:
                    return resultat = tal2 - tal1;
                case Regnetegn.Divider:
                    return resultat = tal2 / tal1;
                case Regnetegn.Gange:
                    return resultat = tal2 * tal1;
            }
            return resultat;
       
        }



    }
}

