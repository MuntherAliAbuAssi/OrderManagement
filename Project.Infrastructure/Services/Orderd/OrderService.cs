using AutoMapper;
using CMS.Core.Exceptions;
using Microsoft.EntityFrameworkCore;
using Project.Core.Dtos;
using Project.Core.ViewModel;
using Project.Data;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Services.Orderd 
{
    public class OrderService : IOrderService
    {
        private readonly ProjectsContext _db;
        private readonly IMapper _mapper; 
        public OrderService(ProjectsContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public  OrderViewModel Get(int Id)
        {
            var order =  _db.Orders.SingleOrDefault(x => x.Id == Id);
            if (order == null)
            {
                // throw new httpNotfound();
            }
            var orderVm = _mapper.Map<OrderViewModel>(order);

            return orderVm;
        }
        public Order Create(CreateOrderDto dto)
        {
            if (IsAvaliable())
            {
                var order = _mapper.Map<Order>(dto);

                 _db.Orders.Add(order);
                 _db.SaveChanges();
                return order;
            }
            
            throw new QuantiyNotFoundException();
        }
        public Order Update(UpdateOrderDto dto)
        {
            if (IsAvaliable())
            {
                
                var order =  _db.Orders.SingleOrDefault(x => x.Id == dto.Id);

                var orderMap = _mapper.Map<Order>(order);

                _db.Orders.Update(orderMap);
                 _db.SaveChanges();
                return orderMap;
            }
            throw new QuantiyNotFoundException();
        }
        public int Delete(int Id)
        {
            var order =  _db.Orders.SingleOrDefault(x => x.Id == Id);
            if (order == null)
            {
                // throw new httpNotfound();
            }
            order.Archived = true;
            _db.Orders.Update(order);
             _db.SaveChanges();
            return order.Id; 
        }
        public bool IsAvaliable()
        {
            var isfound = _db.RestaurantMenus.Any(x => x.Quantity>0);
            if (isfound)
            {
                return true;
            }
            return false;
        }
    
    
    }
}
