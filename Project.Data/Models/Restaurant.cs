using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Data.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            RestaurantMenus = new HashSet<RestaurantMenu>();
            Archived = false;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Archived { get; set; } 

        public virtual ICollection<RestaurantMenu> RestaurantMenus { get; set; }
    }
}
