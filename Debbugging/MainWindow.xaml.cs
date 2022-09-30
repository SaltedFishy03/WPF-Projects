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

namespace Debbugging
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

        private void tb_resultat_Click(object sender, RoutedEventArgs e)
        {
            int iTal1 = 4;
            int iTal2 = 0;
            int iResultat = 0;

            iResultat = iTal1 / iTal2;

            tb_fejl.Text = iResultat.ToString();

        }
    }
}
