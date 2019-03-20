using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lab_300_RazorPagesCustomer_Version_2.Models;

namespace lab_300_RazorPagesCustomer_Version_2.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly lab_300_RazorPagesCustomer_Version_2.Models.NorthwindModel _context;

        public CreateModel(lab_300_RazorPagesCustomer_Version_2.Models.NorthwindModel context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}