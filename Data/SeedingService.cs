using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWeb.Models;

namespace VendasWeb.Data
{
    public class SeedingService
    {
        private VendasWebContext _context;

        public SeedingService(VendasWebContext context)
        {
            _context = context;
        }
    }
}
