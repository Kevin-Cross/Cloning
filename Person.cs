using System;

namespace SharedPersonLib
{
    public class Person : ICloneable
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DOB { get; set; }

        internal Person(int id, string lastName, string firstName, DateTime dob)
        {
            ID = id;
            LastName = lastName;
            FirstName = firstName;
            DOB = dob;
        }

        public Person(Person other) : this(other.ID, other.LastName, other.FirstName, other.DOB)
        {

        }
         
        public override string ToString()
        {

            return $"{ID:000-00-0000} {LastName,-15} {FirstName,-15} {DOB:yyyy-MM-dd}";
        }

        public object Clone()
        {
            return new Person(this);

        }

        public int GetAge(DateTime year)
        {
            return DateTime.Now.Year - year.Year;
        }

        public string GetFormattedID()
        {
            return $"{ID % 10000:XXX-XX-0000}";
        }

        public static string GetHeader()
        {
            return String.Format("{0,-11} {1,-15} {2,-15} {3,-13}", "ID", "Last Name", "First Name", "Date of Birth");
        }
    }
}
