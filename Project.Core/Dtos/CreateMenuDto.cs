using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Dtos
{
    public class CreateMenuDto
    {
        [Required]
        public string MealName { get; set; }
        public double PriceInNis { get; set; }
        public int Quantity { get; set; }   
        public int RestaurantId { get; set; }
    }
}
