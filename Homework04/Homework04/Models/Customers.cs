using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework04.Models
{
    public class Customers
    {
        public List<Person> people = new List<Person>() { };
        
        public Customers(List<Person> people)
        {
            this.people = people;  
        }
        public void addPerson(Person person)
        {
            people.Add(person);
        }
        public List<Person> getPersons()
        {
            return this.people;
        }
     
    }
}