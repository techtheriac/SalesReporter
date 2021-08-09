using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SalesReporter.Models;

namespace SalesReporter.DataLayer
{
    public class SalesReporterContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=LAPTOP-0VSJ0RU3;Initial Catalog=SalesReport;Integrated Security=True;Pooling=False");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var data = File.ReadAllText(
                @"C:\Users\hp\source\repos\SalesReporter\SalesReporter.DataLayer\JsonFiles\Suppliers.json");
            var listOfSuppliers = JsonConvert.DeserializeObject<List<Supplier>>(data);
            builder.Entity<Supplier>().HasData(listOfSuppliers);
        }

    }
}
