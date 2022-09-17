using AutoMapper;
using Project.Core.Dtos;
using Project.Core.ViewModel;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastracture.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            //Customer
            CreateMap<CreateCustomerDto,Customer>();
            CreateMap<UpdateCustomerDto,Customer>();
            CreateMap<Customer, CustomerViewModel>();
            //Resturent
            CreateMap<CreateResturentDto, Restaurant>();
            CreateMap<UpdateResturentDto, Restaurant>();
            CreateMap<Restaurant,ResturentViewModel>();
            //Menu
            CreateMap<CreateMenuDto, RestaurantMenu>();
            CreateMap<UpdateMenuDto, RestaurantMenu>();
            CreateMap<RestaurantMenu, MenuViewModel>();
            //Order
            CreateMap<CreateOrderDto, Order>();
            CreateMap<UpdateOrderDto, Order>();
            CreateMap<Order, OrderViewModel>();
            //
            CreateMap<ScvView, CsvViewModel>();

        }
    }
}
