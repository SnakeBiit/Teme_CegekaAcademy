using Homework04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Homework04.Controllers
{
    public class DealershipController : ApiController
    {

        public static List<Car> delearshipCars = new List<Car>() { };
        public Dealership dealership = new Dealership(delearshipCars) ;
        
        [Route("api/cars/insertCars")]
        [HttpPost]
        public IHttpActionResult CreateCar(Car car)
        {
            if(car == null)
            {
                return BadRequest();
            }
            dealership.addCars(car);
            return Ok(car);
        }

        [Route("api/cars/getCars")]
        [HttpGet]
        public IHttpActionResult showCars()
        {
            return Ok(delearshipCars);  
        }
        [Route("api/cars/deleteCars/{id}")]
        [HttpDelete]
        public  IHttpActionResult deleteCar(int id)
        {
            dealership.removeCar(id);
            return Ok(dealership.getCars());
        }

        [Route("api/cars/updateCars/{id}")]
        [HttpPut]
        public IHttpActionResult updateCar(int id, Car car)
        {
            for(int i = 0; i < dealership.cars.Count(); i++)
            {
                if(id == dealership.cars[i].id)
                {
                    dealership.cars[i].id= car.id ;
                    dealership.cars[i].carBrand= car.carBrand ;
                    dealership.cars[i].carColor= car.carColor ;
                    dealership.cars[i].carModel=car.carModel ;
                    dealership.cars[i].engineSize = car.engineSize ;
                    dealership.cars[i].fuel = car.fuel  ;
                }
            }
            return Ok(car);
        }


        public static List<Person> persons = new List<Person>();
        Customers customers = new Customers(persons);
        

        [Route("api/customers/addCustomer")]
        [HttpPost]
        public IHttpActionResult addCustomer(Person person)
        {
            customers.addPerson(person);
            return Ok(person);
        }

        [Route("api/customers/getCustomers")]
        [HttpGet]
        public IHttpActionResult getCustomers()
        {
            return Ok(customers.getPersons());
        }

        [Route("api/customers/getCustomer/{id}")]
        [HttpGet]
        public IHttpActionResult getCustomer(int id)
        {
            for (int i = 0; i < persons.Count(); i++)
            {
                if (id == persons[i].id) return Ok(persons[i]);
            }
            return Ok();
        }

        [Route("api/customers/buyCar/{customerId},{carId}")]
        [HttpGet]
        public IHttpActionResult addCar(int customerId, int carId)
        {
           Car car = dealership.findCar(carId);
           for (int i = 0; i < persons.Count(); i++)
            {
                if (customerId == customers.people[i].id) customers.people[i].addCar(car);
            }
            return Ok(car);
        }
    }
}
