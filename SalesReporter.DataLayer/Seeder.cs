using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SalesReporter.Models;

namespace SalesReporter.DataLayer
{
    public class Seeder
    {
        public static async Task SeedData(SalesReporterContext context)
        {
            try
            {
                context.Database.EnsureCreated();

                // If no data in Customers
                if (!context.OrderDetails.Any())
                {
                    var data = File.ReadAllText(
                        @"C:\Users\hp\source\repos\SalesReporter\SalesReporter.DataLayer\JsonFiles\OrderDetails.json");
                    var listOfShippers = JsonConvert.DeserializeObject<List<OrderDetail>>(data);
                    
                    await context.OrderDetails.AddRangeAsync(listOfShippers);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
