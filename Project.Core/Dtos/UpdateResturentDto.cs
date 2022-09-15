using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Dtos
{
    public class UpdateResturentDto
    {
        public UpdateResturentDto()
        {
            UpdateDate = DateTime.Now;
        } 
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime UpdateDate { get; set; }
       
    }
}
