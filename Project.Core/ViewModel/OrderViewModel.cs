using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int CustamerId { get; set; }
        public int RestaurantMenuId { get; set; }
    }
}
