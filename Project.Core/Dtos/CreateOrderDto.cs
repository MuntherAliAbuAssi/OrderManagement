using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Dtos
{
    public class CreateOrderDto
    {
        public int CustamerId { get; set; }
        public int RestaurantMenuId { get; set; }
    }
}
