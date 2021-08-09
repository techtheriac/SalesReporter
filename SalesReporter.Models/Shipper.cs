using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesReporter.Models
{
    public class Shipper
    {
        [Key]
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
