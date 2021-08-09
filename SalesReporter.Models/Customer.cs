using System;
using System.Collections.Generic;
using System.Text;

namespace SalesReporter.Models
{
    class Customer
    {
        public string Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
    }
}
