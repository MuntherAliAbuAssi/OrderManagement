using AutoMapper;
using CsvHelper;
using Project.Core.ViewModel;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Services.CSV
{
    public class CsvService : ICsvService
    {
        private readonly IMapper _mapper;
        private readonly ProjectsContext _db;
        public CsvService(IMapper mapper, ProjectsContext db)
        {
            _mapper = mapper;
            _db =db;
        }

        public List<CsvViewModel> Csv()
        {
            var viewResult = _db.ScvViews.ToList();
            var mappingModelView = _mapper.Map<List<CsvViewModel>>(viewResult);
            using (var writer = new StreamWriter("E:\\Munther.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(mappingModelView);
            }
            return mappingModelView;
        }
    }
}
