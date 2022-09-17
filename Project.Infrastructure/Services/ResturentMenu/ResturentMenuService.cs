using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project.Core.Dtos;
using Project.Core.ViewModel;
using Project.Data;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;



namespace Project.Infrastructure.Services.ResturentMenu
{
    public class ResturentMenuService : IResturentMenuService
    { 
        private readonly ProjectsContext _db;
        private readonly IMapper _mapper;
        public ResturentMenuService(ProjectsContext db, IMapper mapper)
        { 
            _db = db;
            _mapper = mapper;
        }
        public MenuViewModel Get(int Id)
        {
            var menu =  _db.RestaurantMenus.SingleOrDefault(x => x.Id == Id);
            if (menu == null)
            {
                // throw new httpNotfound();
            } 
            var menuVm = _mapper.Map<MenuViewModel>(menu);
             
            return menuVm;
        }
        public  RestaurantMenu Create(CreateMenuDto dto)
        {
            var menu = _mapper.Map<RestaurantMenu>(dto);
            menu.PriceInUsd = (dto.PriceInNis/3.50m); 
             _db.RestaurantMenus.Add(menu);
             _db.SaveChanges();
            return menu; 
        }  
        public RestaurantMenu Update(UpdateMenuDto dto)
        {
            var menues =  _db.RestaurantMenus.SingleOrDefault(x => x.Id == dto.Id);

            var menueUpdate = _mapper.Map<RestaurantMenu>(menues);

            _db.RestaurantMenus.Update(menueUpdate);
             _db.SaveChanges();
            return menueUpdate;
        }
        public int Delete(int Id)
        {
            var menue =  _db.RestaurantMenus.SingleOrDefault(x => x.Id == Id);
            if (menue == null)
            {
                // throw new httpNotfound();
            }
            menue.Archived = true;
            _db.RestaurantMenus.Update(menue);
             _db.SaveChanges();
            return menue.Id;
        }
    }
}
