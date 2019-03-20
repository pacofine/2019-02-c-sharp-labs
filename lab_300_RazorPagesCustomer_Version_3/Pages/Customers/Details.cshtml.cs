using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_300_RazorPagesCustomer_Version_2.Models;

namespace lab_300_RazorPagesCustomer_Version_2.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly lab_300_RazorPagesCustomer_Version_2.Models.NorthwindModel _context;

        public DetailsModel(lab_300_RazorPagesCustomer_Version_2.Models.NorthwindModel context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.CustomerID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
