using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Core.Dtos;
using Project.Infrastructure.Services.Customers;
using System.Threading.Tasks;

namespace Project.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Get(int Id)
        {
           var cutomer=  _customerService.Get(Id);
            return Ok(cutomer);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateCustomerDto dto)
        {
            var cutomer =  _customerService.Create(dto);
            return Ok(cutomer);
        }
        [HttpPut]
        public IActionResult Update(UpdateCustomerDto dto)
        {
            var customer =  _customerService.Update(dto);
            return Ok(customer);
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var customer =  _customerService.Delete(Id);
            return Ok(customer); 
        }
    }
}
