using System;


namespace homework01_var2
{
    class Program
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
        static void Main(string[] args)
        {
            Car car1 = new Car(Car.CarBrand.BMW, "blue", "black", false, "red", Car.Packages.entryPackage);
            //var car2 = Car.accessCar(car1); -> copy a car using a static method
            Car car3 = new Car(Car.CarBrand.Aston, "green", "black", false, "black", Car.Packages.plusPackage);
            Car car4 = new Car(Car.CarBrand.Rolls_Royce, "dark grey", "black", true, "black", Car.Packages.ultraPackage);
            car1.displayCar();          
            car3.displayCar();
            car4.displayCar();
            //Car.printAllCars();
            //Console.WriteLine(Car.printAmountOfCars());
            MainMenu();
            
           
        }
        private static void MainMenu()
        {
            Console.WriteLine("Welcome to ShowRoom.");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Print all cars.");
            Console.WriteLine("2. Print the amount of cars.");
            Console.WriteLine("3. Console clear.");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Car.printAllCars();
                    MainMenu();
                    break;
                case "2":
                    Console.WriteLine("\nThe amount of cars: " + Car.printAmountOfCars() + "\n");
                    MainMenu();
                    break;
                case "3":
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    MainMenu();
                    break;
            }
           
        }
       
    }
}
