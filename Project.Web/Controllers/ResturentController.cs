using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Core.Dtos;
using Project.Infrastracture.Services.Resturents;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace Project.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResturentController : ControllerBase
    {
        private readonly IResturentService _resturentService;
        public ResturentController(IResturentService resturentService)
        {
            _resturentService = resturentService;
        }
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var cutomer =  _resturentService.Get(Id);
            return Ok(cutomer);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateResturentDto dto)
        {
            var cutomer =  _resturentService.Create(dto);
            return Ok(cutomer);
        }
        [HttpPut] 
        public IActionResult Update(UpdateResturentDto dto)
        {
            var customer =  _resturentService.Update(dto);
            return Ok(customer);
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var customer =  _resturentService.Delete(Id);
            return Ok(customer);
        }
        [HttpGet]
        public IActionResult CSV(int Id)
        {  
            using (var writer = new StreamWriter("E:\\Munther.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
              //  csv.WriteRecords(mappingModelView);
            }
            return Ok();
        }
    }
}
