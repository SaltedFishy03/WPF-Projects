using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Windows;

namespace ClassAct
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyClass myClass = null;
        public MainWindow()
        {
            InitializeComponent();

        }


        public void bt_create_Click(object sender, RoutedEventArgs e)
        {
            //myClass = new MyClass();
            //myClass.Navn = "Mathias";
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void bt_destroy_Click(object sender, RoutedEventArgs e) 
        { 
            myClass = null;
        }

        class MyClass
        {
            // this is a property with a private setter.
            // Which means that, when its private, i cant gain acces to it and cant type/configering it  
            public int Tal { get; private set; }
            public string Navn { get; private set; } = null;
            public MyClass()
            {
                Debug.Write("Dette er Deafult Constructoren!");
            }
            
            public MyClass(int tal, string navn)
            {
                Tal = tal;
                Navn = navn;

                Debug.Write("Dette er Non-deafult Contructoren!");
            }
        }


    }
}
