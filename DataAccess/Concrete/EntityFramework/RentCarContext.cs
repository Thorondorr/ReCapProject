using Entity.Concreate;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{   
    //Context: Db tabloları ile proje classlarını bağlamak
    public class RentCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=RentCar;Trusted_Connection=true");
        }

        public DbSet<Brands> Brands { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Colors> Colors { get; set; }
       




    }
}
