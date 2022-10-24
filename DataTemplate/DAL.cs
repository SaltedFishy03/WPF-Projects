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

        private ObservableCollection<Person> _dataBase;                                                                     // Da vi ikke har adgang til en database, 
                                                                                                                            // simulerer vi med denne private liste...

 
        private ObservableCollection<Person> _publicListe;                                                                  // Dette er objektet med elementer vi 
                                                                                                                            // "deler ud" til brugeren af vores class.

        //Constructoren her under genererer data til vores falske database
        /// <summary>
        /// DAl bruges til at hente data fra en fiktiv database...
        /// </summary>
        public DAL()
        {
            _dataBase = new ObservableCollection<Person>();
            //_dataBase.Add(new Person(, "Svend", "Bemdt", 1234));
            //_dataBase.Add(new Person(1, "Bein", "Stagge", -987654321));
            //_dataBase.Add(new Person(2, "Turt", "Khorsen", 0));
            //_dataBase.Add(new Person(3, "Gill", "Bates", int.MaxValue));

            _publicListe = new ObservableCollection<Person>();
        }

        // Get henter data fra databasen og kopierer det over i den lokale kopi
        public ObservableCollection<Person> Get()
        {
            _publicListe.Clear();                                                                                           //Først tømmes den lokale kopi

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

        // Insert er en funktion vi har lavet til en knap for at tilføje en ny person
        // som skal inde holde ders ejet ID. fornavn, efternavn og deres formue 
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
        // DeleteBySelection er en funktion til at en knap for at fjerne nogen fra vores daragrid.
        // Funktionen fjerner person fra databasen                                           
        {
            _dataBase.Remove(person);
        }

        // Denne funktion bruger jeg til at finde ID'er på en bestemt person.
        // Den tjekker hver person i min database, hvad deres ID er, og om den matcher med den værdi hvor jeg refferer min funktion i.
        // Matcher ID'et så med den værdi retunere den så alt personens værdi som vi så bruger over hvor vi kaldte denne funktion.
        public Person GetById(int ID)
        {
            foreach (var person in _dataBase)
            {
                if (person.ID == ID)
                    return person;
            }
            return null;
        }
    }
}
    

