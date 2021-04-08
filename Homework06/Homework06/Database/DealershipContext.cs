using Homework06.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06.Database
{
    public class DealershipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=localhost;initial catalog=DealershipCars;integrated security=SSPI;");
        }
        public DbSet<CarCompany> CarCompanies { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
