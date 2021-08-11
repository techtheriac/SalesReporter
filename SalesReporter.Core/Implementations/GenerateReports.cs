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
            throw new NotImplementedException();
        }

        public void GetTopDeals()
        {
            throw new NotImplementedException();
        }


        // Entry Point
        public void Run()
        {

        }
    }
}
