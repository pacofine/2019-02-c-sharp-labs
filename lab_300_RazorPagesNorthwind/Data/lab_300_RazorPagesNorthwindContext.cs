using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab_300_RazorPagesNorthwind.Model;

namespace lab_300_RazorPagesNorthwind.Models
{
    public class lab_300_RazorPagesNorthwindContext : DbContext
    {
        public lab_300_RazorPagesNorthwindContext (DbContextOptions<lab_300_RazorPagesNorthwindContext> options)
            : base(options)
        {
        }

        public DbSet<lab_300_RazorPagesNorthwind.Model.Customer> Customer { get; set; }
    }
}
