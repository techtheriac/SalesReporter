using System;
using SalesReporter.Core;
using SalesReporter.Models;
using SalesReporter.DataLayer;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SalesReporter.Core.Abstractions;
using SalesReporter.Core.Implementations;

namespace SalesReporter
{
    class Program : IDesignTimeDbContextFactory<SalesReporterContext>
    {
        private const string ConnectionString =
            "Data Source=LAPTOP-0VSJ0RU3;Initial Catalog=Sales;Integrated Security=True;Pooling=False";

        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            ConfigureServices();

            SalesReporterContext context = _serviceProvider.GetRequiredService<SalesReporterContext>();
            Seeder.SeedData(context).Wait();


            //Entry Point
            GenerateReports application = new GenerateReports(context);
            application.Init();
            application.Run(0, int.MaxValue);

        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<SalesReporterContext>(options => options.UseSqlServer(ConnectionString));


            _serviceProvider = services.BuildServiceProvider();
        }


        public SalesReporterContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SalesReporterContext>();
            optionsBuilder.UseSqlServer(ConnectionString);
            return new SalesReporterContext(optionsBuilder.Options);
        }
    }
}
