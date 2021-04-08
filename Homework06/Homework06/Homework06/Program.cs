using Homework06.Database;
using Homework06.Entities;
using Homework06.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
namespace Homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<CarCompany> carRepository = new EntityFrameworkRepository<CarCompany>();
            IRepository<CarCompany> carRepositoryMongo = new MongoDbRepository<CarCompany>();
            using (var context = new DealershipContext())
            {
                context.Database.EnsureCreated();
                context.Database.Migrate();
            }

            carRepository.Insert(
               new CarCompany
               {
                   Id = 2,
                   Name = "Dodge"
               });
         
            carRepositoryMongo.Insert(
               new CarCompany
               {
                   Id = 1,
                   Name = "BMW"
               });
           AddCar();
           ReadCar();
           ChangeCar();
           DeleteCar();
        }
        private static void AddCar()
        {
            using (var context = new DealershipContext())
            {
                var car = new CarCompany
                {
                    Id = 1,
                    Name = "Chevy"
                };
               
                context.CarCompanies.Add(car);
                context.SaveChanges();
            }
        }
        private static void ReadCar()
        {
            using (var db = new DealershipContext())
            {

                var query = from b in db.CarCompanies orderby b.Name select b;
                Console.WriteLine("All All student in the database:");

                foreach (var item in query)
                {
                    Console.WriteLine(item.Id + " " + item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
        private static void ChangeCar()
        {

            using (var context = new DealershipContext())
            {

                var car = (from d in context.CarCompanies
                               where d.Name == "Porsche"
                               select d).Single();
                 car.Name= "Audi";
                context.SaveChanges();
            }
        }
        private static void DeleteCar()
        {

            using (var context = new DealershipContext())
            {
                var car = (from d in context.CarCompanies where d.Name == "Dodge" select d).Single();
                context.CarCompanies.Remove(car);
                context.SaveChanges();
            }
        }
    }
}
