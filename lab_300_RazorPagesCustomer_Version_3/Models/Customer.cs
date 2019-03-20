using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_300_RazorPagesCustomer_Version_2.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
