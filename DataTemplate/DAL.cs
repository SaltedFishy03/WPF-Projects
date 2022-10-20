using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplate
{
    public class DAL
    {

        private ObservableCollection<Person> _dataBase = new();  // Da vi ikke har adgang til en database, 
                                                         // simulerer vi med denne private liste...

 
        private ObservableCollection<Person> _publicListe;   // Dette er objektet med elementer vi 
                                                             // "deler ud" til brugeren af vores class.

        //Constructoren genererer data til vores falske database
        public DAL()
        {
            _dataBase = new ObservableCollection<Person>();
            _dataBase.Add(new Person(0, "Svend", "Bemdt", 1234));
            _dataBase.Add(new Person(1, "Bein", "Stagge", -987654321));
            _dataBase.Add(new Person(2, "Turt", "Khorsen", 0));
            _dataBase.Add(new Person(3, "Gill", "Bates", int.MaxValue));

            _publicListe = new ObservableCollection<Person>();
        }

        // Get henter data fra databasen og kopierer det over i den lokale kopi
        public ObservableCollection<Person> Get()
        {
            _publicListe.Clear();   //Først tømmes den lokale kopi

            //Så løber vi alle elementerne igennem i databasen og overfører til lokal kopi
            foreach (Person p in _dataBase)
            {
                _publicListe.Add(p);
            }

            return _publicListe;
        }

        // Commit indsætter vores lokale kopi af data, i databasen
        public void Commit()
        {
            _dataBase = new ObservableCollection<Person>(_publicListe);
        }

        public void Insert(Person person)
        {
            _dataBase.Add(new Person(person.ID, person.Fornavn, person.Efternavn, person.Formue));
        }

        //public bool DeleteByID(int ID)
        //{
        //    bool result = false;
            
        //    Person person = null ;

        //    foreach(var p in _dataBase)
        //    {
        //        if(p.ID == ID)
        //            person = p;
        //    }

        //    _dataBase.Remove(person);

        //    return result;
        //}


        public void DeleteBySelection(Person person)
        {

            _dataBase.Remove(person);
        }

        public Person GetById(int ID)
        {
            foreach (var p in _dataBase)
            {
                if (p.ID == ID)
                    return p;
            }
            return null;
        }
    }
}
    

