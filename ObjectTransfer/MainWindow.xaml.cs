using System;
using System.Collections.Generic;
using System.IO.Pipes;
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

namespace ObjectTransfer
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


        private void btn_overfør_Click(object sender, RoutedEventArgs e)
        {

            InputChecker();
        }


        void InputChecker()
        {

            Window2 person = new Window2("");
            person.Fornavn2 = tb_fornavn1.Text;
            person.Efternavn2 = tb_efternavn1.Text;



            if (int.TryParse(tb_alder1.Text, out int alder1))
            {
                person.alder2 = alder1;

                person.ShowDialog();
            }
            else
            {
                MessageBox.Show("skriv alderen i hele tal");
            }



            if (person.DialogResult == true)
            {
                tb_fornavn1.Text = person.Fornavn2;
                tb_efternavn1.Text = person.Efternavn2;
                tb_alder1.Text = person.alder2.ToString();
            }
            else
            {
                tb_fornavn1.Text = tb_fornavn1.Text;
                tb_efternavn1.Text = tb_efternavn1.Text;
                tb_alder1.Text = tb_alder1.Text;
            }

        }
    }
}
