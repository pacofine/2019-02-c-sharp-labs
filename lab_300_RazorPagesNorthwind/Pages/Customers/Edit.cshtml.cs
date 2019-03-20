using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab_300_RazorPagesNorthwind.Model;
using lab_300_RazorPagesNorthwind.Models;

namespace lab_300_RazorPagesNorthwind.Pages.Customers
{
    public class EditModel : PageModel
    {
        private readonly lab_300_RazorPagesNorthwind.Models.lab_300_RazorPagesNorthwindContext _context;

        public EditModel(lab_300_RazorPagesNorthwind.Models.lab_300_RazorPagesNorthwindContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(Customer.CustomerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CustomerExists(string id)
        {
            return _context.Customer.Any(e => e.CustomerID == id);
        }
    }
}
