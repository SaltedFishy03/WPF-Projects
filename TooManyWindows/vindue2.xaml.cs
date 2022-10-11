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
using System.Windows.Shapes;

namespace TooManyWindows
{
    /// <summary>
    /// Interaction logic for vindue2.xaml
    /// </summary>
    public partial class vindue2 : Window
    {
        public string Navn
        {
            get
            {
                return tb_TypeName.Text;
            }
            set
            {
                tb_TypeName.Text = value;   
            }
        
        }

        //Overload constructor
        public vindue2(string navn)
        {
            InitializeComponent();
            //tb_TypeName.Text = navn;
        }

        
        private void btn_omdøb_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void btn_fortryd_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
