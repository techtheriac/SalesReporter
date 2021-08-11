using System;
using System.Collections.Generic;
using System.Text;
using SalesReporter.Models;

namespace SalesReporter.Core.Abstractions
{
    public interface IGenerateReports
    {

        void GetSalesReports();
        void GetTopCustomers();
        void GetCustomersByCity();
        void GetTopDeals();

    }
}
