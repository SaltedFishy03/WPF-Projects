using Microsoft.VisualBasic;
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

namespace lille_lommeregner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus_click(object sender, RoutedEventArgs e)
        {
            double resultat = RegneFunktion();
            tb_resultat.Text = resultat.ToString();
        }

        private double RegneFunktion(char reggneTegn)
        {
            double tal1 = 0;
            double tal2 = 0;
            double resultat = 0;



            try
            {
                tal1 = Convert.ToDouble(tb_tal1.Text);
                tal2 = Convert.ToDouble(tb_tal2.Text);
                resultat = tal1 + tal2;
            }
            catch (Exception exc)
            {

                MessageBox.Show("Indtast kun tal!!!", exc.Message);





            }

            return resultat;
        }
    }
}
