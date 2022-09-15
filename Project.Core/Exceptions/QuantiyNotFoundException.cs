using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Exceptions
{
   public class QuantiyNotFoundException : Exception
    {
        public QuantiyNotFoundException():base("Qunatity not Found") 
        {

        }
    }
}
