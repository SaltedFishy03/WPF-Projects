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

namespace BMI_beregner
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
        
        private double BMIberegner(double weight, double height)
        {
            ;
            double bmi = weight / height;
            return bmi;
            
        }

        

        private void btn_Beregn_Click(object sender, RoutedEventArgs e)
        {
            string _weight = tb_weight.Text;
            string _height = tb_height.Text;

            double BMI = BMIberegner(double.Parse(_weight), double.Parse(_height)); 
            
          if(cb_gender.Text == "Mand")
            {
                if (true)
                {

                } else if ()
                {

                }
                switch(BMI)
                {
                    case < 20:
                        MessageBox.Show($"Du er en Mand på {_height} cm og {_weight} Kg. \n Hvilket betyder at du er undervægtig");
                        return;
                    case >= 20 && < 25:
                        return;
                }
            } else
            {

            }
        }
    }
}
