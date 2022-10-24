using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplate
{

    public class Person : INotifyPropertyChanged                                        //Her er der blevet lavet et interface INottyFyprpertyChanged som siger til client når der er sket en ændringg
    {
        // I denne propperty laves der et ID
        // som man bruger til at i denfiticere mellem de forskellige personer 
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

        // I denne propperty laves der et fornavn
        // som man kan give og skrive til de forskellige personer
        public string? _fornavn;
        public string? Fornavn
        {
            get
            {
                return _fornavn;                                                        //ved ikke endnu!!!!!!!
            }

            set
            {
                _fornavn = value;                                                       //ved heller ikke endnu!!!!
                OnPropertyChanged("Fornavn");                                           // her bliver der brugt en funktion der er lavet længere nede.
                                                                                        // Den bruges til at når der sker en ændring ved hvilken som helst persons fornavn (i dette tilfælde)
                                                                                        // Og så laver sender den en notifikation til vores client at der er etfonavn ændret
            }
        }

        // laver det samme som fornavn
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

        //laver det samme som fornavn
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

        // Dette er vores constuckter som fortæller hvordan vores "Person" skal se ud/hvad den skal indeholde  
        public Person(int ID, string Fornavn, string Efternavn, int Formue)
        {
            this.ID = ID;
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
            this.Formue = Formue;
        }
        public event PropertyChangedEventHandler? PropertyChanged;                  // Dette event arbejder sammen med INortifyPropertyChanged
                                                                                    // Den gør der kommer besked når der bliver lavet ændringer i property værdierne
       
        
        // Her laves der en funktion til at når der er sket en ændring og er der det
        // (så køre den noget kode jeg ikke ved hvad rigtig gør!!!!!)
        private void OnPropertyChanged(string PropertyNavn)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyNavn));
            }
        }


    } 
}
