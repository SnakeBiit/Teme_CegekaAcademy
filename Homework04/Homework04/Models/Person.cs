using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework04.Models
{
    public class Person
    {
        public int id;
        public string firstName;
        public string lastName;
        public List<Car> cars;
        public Person(int id, string fistName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            cars = new List<Car>();
        }
        public void addCar(Car car)
        {
            cars.Add(car);
        }
    }
}