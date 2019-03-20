using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_300_RazorPagesCustomer_Version_2.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }

        [Display(Name = "Contact name")]
        public string ContactName { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
    }
}
