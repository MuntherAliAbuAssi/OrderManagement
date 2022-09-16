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
        public decimal PriceInNis { get; set; }
        
        private decimal _PriceInUsd;
        public decimal PriceInUsd{
            get  => _PriceInUsd;  
            set => _PriceInUsd = (PriceInNis / 3.5m);
        }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; } 
        public bool Archived { get; set; }
        public int? RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
