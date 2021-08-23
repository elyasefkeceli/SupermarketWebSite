using Microsoft.EntityFrameworkCore;
using Supermarket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.DataAccess.Concrete.EntityFramework
{
    public class SupermarketWebContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SupermarketWebDb;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
