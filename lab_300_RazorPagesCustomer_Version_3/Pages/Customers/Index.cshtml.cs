using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_300_RazorPagesCustomer_Version_2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList ContactName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Country { get; set; }

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Customers
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.ContactName.Contains(SearchString));
            }

            Customer = await movies.ToListAsync();
        }
    }
}
