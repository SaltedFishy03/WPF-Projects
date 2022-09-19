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
            char sign = 's';
            double resultat = RegneFunktion(sign);
            tb_resultat.Text = resultat.ToString();
        }

        private double RegneFunktion(char regneTegn)
        {
            double tal1;
            double tal2;



            if (double.TryParse(tb_tal1.Text, out tal1) && double.TryParse(tb_tal2.Text, out tal2))
            {
                switch (regneTegn)
                {
                    case '+':
                        return tal2 + tal1;
                    case '-':
                        return tal2 - tal1;
                    case '/':
                        return tal2 / tal1;
                    case '*':
                        return tal2 * tal1;
                    default:
                        MessageBox.Show("ikke et gyldigt symbol!!");
                        return 0;
                }
            }
            MessageBox.Show("ikke gyldigt tal!!");
            return 0;
        }
    }
}
