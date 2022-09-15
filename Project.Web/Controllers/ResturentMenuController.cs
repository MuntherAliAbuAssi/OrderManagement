using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Core.Dtos;
using Project.Infrastructure.Services.ResturentMenu;
using System.Threading.Tasks;

namespace Project.Web.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class ResturentMenuController : ControllerBase
    {
        private readonly IResturentMenuService _menuService;
        public ResturentMenuController(IResturentMenuService menuService)
        {
            _menuService = menuService; 
        }
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var menu =  _menuService.Get(Id);
            return Ok(menu);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateMenuDto dto)
        {
            var menu =  _menuService.Create(dto);
            return Ok(menu);
        }
        [HttpPut]
        public IActionResult Update(UpdateMenuDto dto) 
        {
            var menu =  _menuService.Update(dto);
            return Ok(menu);
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var menu =  _menuService.Delete(Id);
            return Ok(menu);
        }
    }
}
