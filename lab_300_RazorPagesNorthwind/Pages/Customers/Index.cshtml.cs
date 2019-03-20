using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_300_RazorPagesNorthwind.Model;
using lab_300_RazorPagesNorthwind.Models;

namespace lab_300_RazorPagesNorthwind.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly lab_300_RazorPagesNorthwind.Models.lab_300_RazorPagesNorthwindContext _context;

        public IndexModel(lab_300_RazorPagesNorthwind.Models.lab_300_RazorPagesNorthwindContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
