﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_300_RazorPagesCustomer_Version_2.Models;

namespace lab_300_RazorPagesCustomer_Version_2.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly lab_300_RazorPagesCustomer_Version_2.Models.NorthwindModel _context;

        public IndexModel(lab_300_RazorPagesCustomer_Version_2.Models.NorthwindModel context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
