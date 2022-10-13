using System;
using System.Windows;

namespace ObjectTransfer
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        
        public string Fornavn2
        {
            get
            {
                return tb_fornavn2.Text;
            }

            set
            {
                tb_fornavn2.Text = value;
            }
        }

        public string Efternavn2
        {
            get
            {
                return tb_efternavn2.Text;
            }

            set
            {
                tb_efternavn2.Text = value;
            }
        }

        public int alder2
        {

            get
            { 
                return int.Parse(tb_alder2.Text);
            }

            set
            {
                tb_alder2.Text = value.ToString();
            }
        }

        public Window2(string person)
        {
            InitializeComponent();
        }

        private void btn_ret_Click(object sender, RoutedEventArgs e)
        {
            Inputchecker2();
        }

        private void btn_fortryd_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
        void Inputchecker2()
        {
            if (int.TryParse(tb_alder2.Text, out int alder1))
            {
                DialogResult = true;
                this.Close();
                alder1 = alder2;

            }
            else
            {
                MessageBox.Show("skriv alderen i hele tal");
            }
        }
    }
}
