using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace SalesReporter.Models
{
    public class OrderDetail
    {
        [Key]
        public string OrderDetailId { get; set; }
        public decimal Price { get; set; }

        public string OrderId { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
    }
}
