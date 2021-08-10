using System;
using SalesReporter.Core;
using SalesReporter.Models;
using SalesReporter.DataLayer;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace SalesReporter
{
    class Program : IDesignTimeDbContextFactory<SalesReporterContext>
    {
        private const string ConnectionString =
            "Data Source=LAPTOP-0VSJ0RU3;Initial Catalog=SalesReport;Integrated Security=True;Pooling=False";
        static void Main(string[] args)
        {

        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<SalesReporterContext>(options => options.UseSqlServer(ConnectionString));
        }


        public SalesReporterContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SalesReporterContext>();
            optionsBuilder.UseSqlServer(ConnectionString);
            return new SalesReporterContext(optionsBuilder.Options);
        }
    }
}
