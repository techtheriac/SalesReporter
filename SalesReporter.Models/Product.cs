using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesReporter.Models
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        public Supplier Supplier { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
    }
}
