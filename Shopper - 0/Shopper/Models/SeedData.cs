using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Shopper.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ShopperContext context = app.ApplicationServices
                .GetRequiredService<ShopperContext>();
            context.Database.Migrate();
            if (!context.Sale.Any())
            {
                context.Sale.AddRange(

                    new Sale
                    {
                        Name = "Dummy",
                        Price = 10M,
                        IsTaxable = true
                    }

                   );
            };
            context.SaveChanges();
        }
    }
}