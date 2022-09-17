using Project.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Services.CSV
{
    public interface ICsvService
    {
        List<CsvViewModel> Csv();
    }
}
