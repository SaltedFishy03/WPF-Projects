using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplate
{

    public class Person : INotifyPropertyChanged
    {
        public int _id;
        public int ID
        {
            get 
            { 
                return _id; 
            }

            set 
            { 
                _id = value; 
            }
        }
        public string? _fornavn;
        public string? Fornavn
        {
            get
            {
                return _fornavn;
            }

            set
            {
                _fornavn = value;
                OnPropertyChanged("Fornavn");
            }
        }

        private string _efternavn;
        public string Efternavn
        {
            get
            {
                return _efternavn;
            }

            set
            {
                _efternavn = value;
                OnPropertyChanged("Efternavn");
            }
        }

        private int _formue;
        public int Formue
        {
            get
            {
                return _formue;
            }
            set
            {
                _formue = value;
                OnPropertyChanged("Formue");
            }
        }
        public Person(int ID, string Fornavn, string Efternavn, int Formue)
        {
            this.ID = ID;
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
            this.Formue = Formue;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string PropertyNavn)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyNavn));
            }
        }


    } 
}
