using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/********************************************************************************************
 * https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-2.2
 * 
 * Add-Migration Initial
 * Update-Database
 * 
********************************************************************************************/


namespace Shopper.Models
{
    public class Sale
    {
        public int SaleID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool IsTaxable { get; set; }

        public decimal? Total { get; set; }
    }
}
