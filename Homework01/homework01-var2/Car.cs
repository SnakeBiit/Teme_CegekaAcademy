using System;
using System.Collections.Generic;
using System.Text;

namespace homework01_var2
{
    class Car
    {
        public enum CarBrand
        {
            BMW,
            Aston,
            Rolls_Royce
        }
        public enum Packages
        {
            entryPackage = 0,
            plusPackage = 1,
            ultraPackage = 2
        }
        private static List<String> totalCars = new List<string>();
        private string traction;
        private string enginePower;
        private string engineSize;
        private string fuel;
        private Packages _carPackages;
        private CarBrand _carBrand;
        private string carColor { get; set; }
        private string wheelColor { get; set; }
        private bool hasHeatedChairs { get; set; }
        private string interiorColor;
        private static int amountOfCars = 0;

        public Car(CarBrand carBrand, string carColor, string wheelColor, bool hasHeatedChairs, string interiorColor, Packages carPackages)
        {
            amountOfCars+=1;
            this._carPackages = carPackages;
            this._carBrand = carBrand;
            this.carColor = carColor;
            this.wheelColor = wheelColor;
            this.hasHeatedChairs = hasHeatedChairs;
            this.interiorColor = interiorColor;
           if (_carPackages.Equals(Car.Packages.entryPackage))
            {
                this.traction = "FWD";
                this.enginePower = "180 CP";
                this.engineSize = "2.0L";
                this.fuel = "diesel";
            }
            else if (_carPackages.Equals(Car.Packages.plusPackage))
            {
                this.traction = "RWD";
                this.enginePower = "280 CP";
                this.engineSize = "2.0L";
                this.fuel = "petrol";
            }
            else if (_carPackages.Equals(Car.Packages.ultraPackage))
            {
                this.traction = "AWD";
                this.enginePower = "400 CP";
                this.engineSize = "3.0L";
                this.fuel = "petrol";
            }
            totalCars.Add(carBrand.ToString());
            totalCars.Add(carPackages.ToString());
            totalCars.Add(enginePower.ToString());
            totalCars.Add(engineSize.ToString());
            totalCars.Add(fuel.ToString());
        }
       
        public static Car accessCar(Car car) //copy a car using a static method
        {
            return car;
        }
        public void displayCar() //display the cars from main
        {
            Console.WriteLine("Car brand: " + _carBrand + "\nCar package: " + _carPackages + "\nCar color: " + carColor + "\nWheel Color: " + wheelColor + "\nInterior color: " + interiorColor + "\nHeated Chairs: " + hasHeatedChairs + "\nTraction: " + traction + "\nEngine Power: " + enginePower +  "\nEngine Size: " + engineSize + "\nFuel: " + fuel + "\n");
        }

        public static int printAmountOfCars()//display the amount of cars that have been manufactured
        {
            return amountOfCars;
        }
        
        public static void printAllCars()//printing all cars from console using a list
        {
            string cars = "";
            foreach(var car in totalCars)
            {
                cars += car + " ";
            }
            Console.WriteLine("\n" + cars + "\n");
        }
    }
}

