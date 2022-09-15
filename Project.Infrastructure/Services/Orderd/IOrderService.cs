using Project.Core.Dtos;
using Project.Core.ViewModel;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Services.Orderd
{
    public interface IOrderService
    {
        OrderViewModel Get(int Id);
        Order Create(CreateOrderDto dto);
        Order Update(UpdateOrderDto dto);
        int Delete(int Id);
    } 
}
