using System;
using suretree.Interfaces;

namespace suretree.Models
{
    public class Person : IPerson
    {
        List<Person> Persons = new List<Person>();

        public Person()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get ; set ; }
        public DateTime DateOfBirth { get; set; }

        public Person GetById(int Id) => Persons.FirstOrDefault(p => p.Id == Id);


        public Person Insert(Person person)
        {
            Persons.Add(person);
            return person;
        }


        List<Person> IPerson.List()
        {
            return Persons;
        }
    }
}

