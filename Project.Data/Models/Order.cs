using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Data.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int CustamerId { get; set; }
        public int RestaurantMenuId { get; set; }
        public bool Archived { get; set; }

        public virtual Customer Custamer { get; set; }
        public virtual RestaurantMenu RestaurantMenu { get; set; }
    }
}
