using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalesReporter.Core.Abstractions;
using SalesReporter.DataLayer;
using SalesReporter.Models;
using ConsoleTables;

namespace SalesReporter.Core.Implementations
{
    public class GenerateReports : IGenerateReports
    {
        private readonly SalesReporterContext _context;

        public GenerateReports(SalesReporterContext context)
        {
            _context = context;
        }

        private bool IsValidInput(string input)
        {
            return input == "sales" ||
                   input == "cd" ||
                   input == "top" ||
                   input == "gbc" ||
                   input == "help";
        }

        private List<string> Manual = new List<string>
        {
            "* Enter 'help' to print this menu",
            "* Enter 'top' to view customers from 5 locations whose orders is greater than 50,000",
            "* Enter 'sales' to view sales report",
            "* Enter 'gbc' to display customers grouped by city"
        };
        public void GetTopCustomers()
        {
            var result = (from p in _context.Orders
                join o in _context.OrderDetails on p.OrderId equals o.OrderId
                select new
                {
                    CityOfCustomer = p.Customer.City,
                    IdOfOrder = p.OrderId,
                    NameOfCustomer = p.Customer.FirstName,
                    NameOfProduct = o.Product.ProductName,
                    PriceOfProduct = o.Product.Price
                }).ToList();

            var priceIsGreaterThanFiftyThousand = 
                result.Where(p => p.PriceOfProduct > 50000.00M)
                    .OrderBy(p => p.CityOfCustomer)
                    .Take(5);


            var table =
            new ConsoleTable(
                "Customer Name",
                "City",
                "OrderId",
                "Price"
            );

            foreach (var item in priceIsGreaterThanFiftyThousand)
            {
                table.AddRow(item.NameOfCustomer, item.CityOfCustomer, item.IdOfOrder, item.PriceOfProduct);
            }

            table.Write();
        }

        public void GetSalesReports()
        {
            var result =
                (from p in _context.Products
                    join o in _context.OrderDetails on p.ProductId equals o.ProductId
                    select new
                    {
                        IdOfProduct = p.ProductId,
                        NameOfProduct = p.ProductName,
                        DateOfOrder = o.Order.OrderDate,
                        UintPrice = o.Price,
                        ItemQuantity = o.Quantity,
                        Total = o.Price * o.Quantity
                    }).Take(10).ToList();

            var table =
                new ConsoleTable
                ("ProductId",
                    "ProductName",
                    "Sale Date",
                    "Unit Price",
                    "Quantity",
                    "Total");

            foreach (var item in result)
            {
                table.AddRow(item.IdOfProduct, item.NameOfProduct, item.DateOfOrder, item.UintPrice, item.ItemQuantity,
                    item.Total);
            }

            table.Write();
        }

        public void GetCustomersByCity()
        {
            var results = _context.Customers.OrderBy(p => p.City);

            var table = new ConsoleTable("City", "CustomerName");

            foreach (var customer in results)
            {
                table.AddRow(customer.City, $"{customer.FirstName} {customer.LastName}");
            }

            table.Write();
        }

        public void GetTopDeals()
        {
            throw new NotImplementedException();
        }

        public void PrintManual()
        {
            foreach (var item in Manual)
            {
                Console.WriteLine(item);
            }
        }


        public void Init()
        {
            Console.WriteLine("Welcome to TopGun SalesReporter");
            PrintManual();
        }

        // Entry Point
        public void Run(int count, int max)
        {
            string subsequentPrompt = count >= 1 ? "What else would you like to do?" : "";
            Console.WriteLine(subsequentPrompt);

            Console.Write(">> ");
            string _action = Console.ReadLine().ToLower();

            if (count >= max || _action == "exit")
            {
                return;
            }

            if (IsValidInput(_action) == false)
            {
                Console.WriteLine("You have made an invalid selection");
                Run(count, int.MaxValue);
            }

            switch (_action)
            {
                case "sales":
                    GetSalesReports();
                    break;
                case "top":
                    GetTopCustomers();
                    break;
                case "help":
                    PrintManual();
                    break;
                case "gbc":
                    GetCustomersByCity();
                    break;
                default:
                    Run(count, int.MaxValue);
                    break;
            }

            Run(count + 1, int.MaxValue);

        }
    }
}
