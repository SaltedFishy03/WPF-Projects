using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TwoWayTest
{
    public class Person
    {
        public int ID;
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public int Formue { get; set; }

        public Person(int ID, string Fornavn, string Efternavn, int Formue)
        {
            this.ID = ID;
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
            this.Formue = Formue;

            
            
        }
    }
}
