using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonManager.Models
{
    public class Opreations
    {
        private static List<Person> Person = new List<Person>()
        {
            new Person() {Id = 1000, FirstName = "Litesh", LastName = "Koteshwaran", Email = "Litesh.ranjani.2096@gmail.com", PhoneNo = 9036213630},
            new Person() {Id = 1001, FirstName = "Bharath", LastName = "Koteshwaran", Email = "Bharath@gmail.com", PhoneNo = 1234567891},
            new Person() {Id = 1002, FirstName = "Suryaa", LastName = "Babu", Email = "Suryaa@gmail.com", PhoneNo = 0987654321},
            new Person() {Id = 1003, FirstName = "Keerthana", LastName = "Babu", Email = "Keerthana@gmail.com", PhoneNo = 4378219733},
            new Person() {Id = 1004, FirstName = "Kavaya", LastName = "Babu", Email = "Kavya@example.com", PhoneNo = 3847343984},
        };

        public List<Person> Persons
        {
            get { return Person; }
        }

        public Person SearchPersonById(int Id)
        {
            return Person.First(X => X.Id == Id);
        }

        public List<Person> DeletePerson(int Id)
        {
            Person person = (Person)Person.Find(X => X.Id == Id);
            Person.RemoveAt(Person.IndexOf(person));
            return Person;
        }

        public void EditPersonDetails(Person person)
        {
            Person personForIndex = (Person)Person.Find(X => X.Id == person.Id);
            int index = Person.IndexOf(personForIndex);
            Person[index] = person;
        }
    }
}