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

namespace TooManyWindows
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

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            vindue2 vindue = new vindue2("");
            vindue.Navn = "Mathias";
            tb_1.Text = vindue.Navn;
            vindue.ShowDialog();

            if (vindue.DialogResult == true)
            {
                tb_1.Text = "hej med dig " + vindue.Navn;
            }
            else
            {
                tb_1.Text = "Du hedder stadig Mathias";
            }


        }
    }
}
