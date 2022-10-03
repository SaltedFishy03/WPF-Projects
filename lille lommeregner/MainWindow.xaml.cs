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
        /// Dette er en enum der definere de oprindelige regnetegn
        /// </summary>
        enum Regnetegn
        {
            Plus,
            Minus,
            Divider,
            Ganger
        }
        private void plus_click(object sender, RoutedEventArgs e)
        {
            char sign = '+';
            double resultat = RegneFunktion(sign);
            symbol.Text = sign.ToString();
            tb_resultat.Text = resultat.ToString();
        }
        
        private void minus_click(object sender, RoutedEventArgs e)
        {
            char sing = '-';
            double resultat = RegneFunktion(sing);
            symbol.Text = sing.ToString();
            tb_resultat.Text = resultat.ToString();
        }

        private void gange_click(object sender, RoutedEventArgs e)
        {
            char sing = '*';
            double resultat = RegneFunktion(sing);
            symbol.Text = sing.ToString();
            tb_resultat.Text = resultat.ToString();
        }

        private void division_click(object sender, RoutedEventArgs e)
        {
            RegneFunktion(Regnetegn.Divider);

            //char sing = '/';
            //double resultat = RegneFunktion(sing);
            symbol.Text = btn_division.Content.ToString();
            //tb_resultat.Text = resultat.ToString();
        }

        private double RegneFunktion(Regnetegn regnetegn)
        {
            double tal1;
            double tal2;



            if (double.TryParse(tb_tal1.Text, out tal1) && double.TryParse(tb_tal2.Text, out tal2))
            {
                if (regnetegn == Regnetegn.Divider)
                {


                }


            //    switch (regneTegn)
            //    {
            //        case '+':
            //            return tal2 + tal1;
            //        case '-':
            //            return tal2 - tal1;
            //        case '/':
            //            return tal2 / tal1;
            //        case '*':
            //            return tal2 * tal1;
            //        default:

                        
            //            MessageBox.Show("ikke et gyldigt symbol!!");
            //            return 0;
            //    }


            }
            MessageBox.Show("ikke gyldigt tal!!");
            return 0;
        }
    }
}
