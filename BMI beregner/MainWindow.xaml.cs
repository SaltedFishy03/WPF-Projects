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
            double bmi = weight / Math.Pow (height / 100, 2);
            return bmi;
        }



        private void btn_Beregn_Click(object sender, RoutedEventArgs e)
        {
            string _weight = tb_weight.Text;
            string _height = tb_height.Text;

            double BMI = BMIberegner(double.Parse(_weight), double.Parse(_height));

            if (cb_gender.Text == "Mand")
            {
                if (BMI < 20)
                {
                    MessageBox.Show($"Du er en Mand på {_height} cm og {_weight} Kg, så din BMI bliver {string.Format("{0:0,00}", BMI)}. \nHvilket betyder at du er undervægtig.");
                    return;

                }

                else if (BMI >= 20 && BMI < 25)
                {
                    MessageBox.Show($"Du er en Mand på {_height} cm og {_weight} kg, så din BMI bliver {string.Format("{0:0.00}", BMI)}. \nHvilket betyder du er normalvægtig.");
                    return;

                }

                else if (BMI >= 25 && BMI < 30)
                {
                    MessageBox.Show($"Du er en Mand på {_height} cm og {_weight} kg, så din BMI bliver {string.Format("{0:0.00}", BMI)}. \nHvilket betyder du er overvægtig.");
                    return;

                }

                else
                {
                    MessageBox.Show($"Du er en Mand på {_height} cm og {_weight} kg, så din BMI bliver {string.Format("{0:0.00}", BMI)}. \nHvilket betyder du er stærkt overvægtig.");
                    return;
                }
            }
            else
            {
                if (BMI < 18.6)
                {
                    MessageBox.Show($"Du er en Kvinde på {_height} cm og {_weight} kg, så din BMI bliver {string.Format("{0:0.00}", BMI)}. \nHvilket betyder du er undervægtig.");
                    return;
                }
                
                else if (BMI >= 18.6 && BMI < 23.6)
                {
                    MessageBox.Show($"Du er en Kvinde på {_height} cm og {_weight} kg, så din BMI bliver {string.Format("{0:0.00}", BMI)}. \nHvilket betyder du er normalvægtig.");
                    return;
                }

                else if (BMI >= 23.6 && BMI < 28.6)
                {
                    MessageBox.Show($"Du er en Kvinde på {_height} cm og {_weight} kg, så din BMI bliver {string.Format("{0:0.00}", BMI)}. \nHvilket betyder du er overvægtig.");
                    return;
                }

                else
                {
                    MessageBox.Show($"Du er en Kvinde på {_height} cm og {_weight} kg, så din BMI bliver {string.Format("{0:0.00}", BMI)}. \nHvilket betyder du er stærkt overvægtig.");
                    return;
                }
            }

        }
    }
}



//                switch(BMI)
//                {
//                    case < 20:
                     
//                    case >= 20 && < 25;
//                        return;
//                }
//            } else
//            {

//            }
//        }
//    }
//}
