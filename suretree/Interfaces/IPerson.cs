using System;
using suretree.Models;

namespace suretree.Interfaces
{
    public interface IPerson
    {
     

        Person Insert(Person person);

        List<Person> List();

        Person GetById(int Id);


    }

}

