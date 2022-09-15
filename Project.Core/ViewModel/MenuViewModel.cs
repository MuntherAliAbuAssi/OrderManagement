using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.ViewModel
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public double PriceInNis { get; set; }
        public double PriceInUsd { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public int RestaurantId { get; set; }
    }
}
