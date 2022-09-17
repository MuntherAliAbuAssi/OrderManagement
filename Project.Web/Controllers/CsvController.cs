using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Infrastructure.Services.CSV;

namespace Project.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CsvController : ControllerBase
    {
        private readonly ICsvService _csv;
        public CsvController(ICsvService csv)
        {
            _csv = csv;
        }
        [HttpGet]
        public IActionResult CsvExcel()
        {
            _csv.Csv();
            return Ok();
        }
    }
}
