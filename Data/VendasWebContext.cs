using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendasWeb.Models
{
    public class VendasWebContext : DbContext
    {
        public VendasWebContext (DbContextOptions<VendasWebContext> options)
            : base(options)
        {
        }

        public DbSet<VendasWeb.Models.Department> Department { get; set; }
    }
}
