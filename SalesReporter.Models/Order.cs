using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesReporter.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public Customer Customer { get; set; }
        public Shipper Shipper { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
