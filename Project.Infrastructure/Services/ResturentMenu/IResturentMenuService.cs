using Project.Core.Dtos;
using Project.Core.ViewModel;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Services.ResturentMenu
{
    public interface IResturentMenuService 
    {
        MenuViewModel Get(int Id);
        RestaurantMenu Create(CreateMenuDto dto);
        RestaurantMenu Update(UpdateMenuDto dto);
        int Delete(int Id);
    }
}
