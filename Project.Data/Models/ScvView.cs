using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Data.Models
{
    public partial class ScvView
    {
        public string NameResturent { get; set; }
        public int? OrdersCount { get; set; }
        public double? PriceInUsdTotal { get; set; }
        public double? PriceInNisTotal { get; set; }
        public string MostPurchasedCustomer { get; set; }
        public string TheBestSellingMeal { get; set; }
    }
}
