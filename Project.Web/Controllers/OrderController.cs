using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Core.Dtos;
using Project.Infrastructure.Services.Orderd;
using System.Threading.Tasks;

namespace Project.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var menu =  _orderService.Get(Id);
            return Ok(menu);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateOrderDto dto)
        {
            var menu =  _orderService.Create(dto);
            return Ok(menu);
        }
        [HttpPut]
        public IActionResult Update(UpdateOrderDto dto)
        {
            var menu =  _orderService.Update(dto);
            return Ok(menu);
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var menu =  _orderService.Delete(Id);
            return Ok(menu);
        }
    }
}
