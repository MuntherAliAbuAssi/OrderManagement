using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.ViewModel
{
    public class CsvViewModel
    { 
        public string NameResturent { get; set; }
        public int? OrdersCount { get; set; }
        public double? PriceInUsdTotal { get; set; }
        public double? PriceInNisTotal { get; set; }
        public string MostPurchasedCustomer { get; set; }
        public string TheBestSellingMeal { get; set; }
    }
}
