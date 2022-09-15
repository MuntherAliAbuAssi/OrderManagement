using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Services.Extentions
{
    public static class Captlaize
    {
        public static string NameCapital(this string name)
        {
            return name[0].ToString().ToUpper() + name.Substring(1);
        }
    }
}
