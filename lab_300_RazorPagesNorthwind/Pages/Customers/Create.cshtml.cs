using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lab_300_RazorPagesNorthwind.Model;
using lab_300_RazorPagesNorthwind.Models;

namespace lab_300_RazorPagesNorthwind.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly lab_300_RazorPagesNorthwind.Models.lab_300_RazorPagesNorthwindContext _context;

        public CreateModel(lab_300_RazorPagesNorthwind.Models.lab_300_RazorPagesNorthwindContext context)
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

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}