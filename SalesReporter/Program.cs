using System;
using SalesReporter.Core;
using SalesReporter.Models;
using SalesReporter.DataLayer;
using Autofac;
using System.Reflection;
using Autofac.Core;

namespace SalesReporter
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                scope.Resolve<Application>().Run();
            }
        }


        private static IContainer BuildContainer()
        {
            //Registering individual Dependencies
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>();
            builder.RegisterType<SalesReporterContext>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsSelf()
                .AsImplementedInterfaces(); 

            return builder.Build();
        }
    }
}
