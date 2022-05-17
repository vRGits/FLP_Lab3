using Core.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class CalorieContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Consumption> Consumptions { get; set; }

        public CalorieContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = LAPTOP-QLLRIN6T;Database=CalorieDB;Trusted_connection=True;");
        }
    }
}
