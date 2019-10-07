using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shopper.Models
{
    public class ShopperContext : DbContext
    {
        public ShopperContext (DbContextOptions<ShopperContext> options)
            : base(options)
        {
        }

        public DbSet<Shopper.Models.Sale> Sale { get; set; }
    }
}
