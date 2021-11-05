using System;
using System.Collections.Generic;
using SharedPersonLib;



namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lp = new List<Person>();
            PersonFactory factory = PersonFactory.Instance;
           
            lp.Add(factory.Create(123456789, "Smith", "Jane", DateTime.Parse("2001-06-03")));
            lp.Add(factory.Create(234567891, "Smath", "John", DateTime.Parse("2000-12-30")));
            lp.Add(factory.Create(345678912, "Jordan", "Michael", DateTime.Parse("1961-1-04")));
            lp.Add(factory.Create(456789123, "Pippen", "Scottie", DateTime.Parse("1964-5-20")));
            lp.Add(factory.Create(567891234, "Oneal", "Shaquille", DateTime.Parse("1973-2-25")));
            lp.Add(lp[0].Clone() as Person);
            
            lp[5].LastName = "Smith-Jones";
            lp[5].FirstName = "Janie";

            Console.WriteLine(Person.GetHeader());
            foreach (Person x in lp)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
