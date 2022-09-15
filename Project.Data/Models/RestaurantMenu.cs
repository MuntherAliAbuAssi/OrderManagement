using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Data.Models
{
    public partial class RestaurantMenu
    {
        public RestaurantMenu()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string MealName { get; set; }
        public double PriceInNis { get; set; } 
        public double PriceInUsd { get => PriceInUsd; set => PriceInUsd *=3.5; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; } 
        public bool Archived { get; set; }
        public int? RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
