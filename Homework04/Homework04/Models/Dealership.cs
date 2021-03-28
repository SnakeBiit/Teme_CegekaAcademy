using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework04.Models
{
    public class Dealership
    {
        public List<Car> cars = new List<Car>();
        
        public  Dealership(List<Car> cars)
        {
            this.cars = cars;
        }
        public void addCars(Car car)
        {
            cars.Add(car);
        }
        public List<Car> getCars()
        {
            return cars;
        }
        public Car findCar(int id)
        {
            Car car = new Car(0,"","","",0,"");
            for (int i = 0; i < cars.Count(); i++)
            {
                if (id == cars[i].id)
                {
                    car.id = cars[i].id;
                    car.fuel = cars[i].fuel;
                    car.engineSize = cars[i].engineSize;
                    car.carModel = cars[i].carModel;
                    car.carColor = cars[i].carColor;
                    car.carBrand = cars[i].carBrand;
                };
            }
            return car;
        }
        public void removeCar(int id)
        {
            for( int i = 0; i < cars.Count();i++)
            {
                if (id == cars[i].id) cars.Remove(cars[i]);
            }
        }
       

    }
}