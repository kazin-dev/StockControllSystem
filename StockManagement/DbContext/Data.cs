using System;
using Microsoft.EntityFrameworkCore;

namespace StockManagement.DbData
{
    public class AppDbContext : DbContext
    {
        // the data that I want on the table
        public DbSet<Product>? products {get; set;}

        // the path and way to find the db file
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Environment.SystemDirectory;
            var local = System.IO.Path.Combine(path, "Management.db");

            optionsBuilder.UseSqlite($"Data Source = {local}");
        }

    } 
        
}