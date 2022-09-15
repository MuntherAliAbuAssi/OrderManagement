using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Dtos
{
    public class UpdateMenuDto
    {
        public UpdateMenuDto()
        {
            UpdatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string MealName { get; set; }
        public double PriceInNis { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int RestaurantId { get; set; }
    }
}
