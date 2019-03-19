using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_1000_entity_project.Models;
using Microsoft.EntityFrameworkCore;

namespace lab_1000_entity_project.Pages
{
    public class CustomersModel : PageModel
    {
        public List<Customer> customers = new List<Customer>();

        [BindProperty]
        public CustomersModel customer { get; set; }

        private Northwind db;
        private CustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "List of Northwind Customers";
            customers = db.Customers.OrderBy(c => c.ContactName).ToList();
        }
    }
}