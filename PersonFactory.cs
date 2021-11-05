using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedPersonLib
{
    public class PersonFactory
    {
        private static PersonFactory _Instance;

        static PersonFactory()
        {
            Instance = new PersonFactory();
        }
        
        private PersonFactory()
        {

        }

        public static PersonFactory Instance { get => _Instance; private set => _Instance = value; }

        public Person Create(int id, string lastName, string firstName, DateTime dob)
        {
            return new Person(id, lastName, firstName, dob);
        }
    }
}
