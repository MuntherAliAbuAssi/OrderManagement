using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project.Core.Dtos;
using Project.Core.ViewModel;
using Project.Data;
using Project.Data.Models;
using Project.Infrastracture.Services.Resturents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Project.Infrastructure.Services.Resturents
{
    public class ResturentService : IResturentService
    {
        private readonly ProjectsContext _db; 
        private readonly IMapper _mapper;
        public ResturentService(ProjectsContext db, IMapper mapper)
        { 
            _db = db; 
            _mapper = mapper;
        }
        public ResturentViewModel Get(int Id)
        {
            var resturent =  _db.Restaurants.SingleOrDefault(x => x.Id == Id);
            if (resturent == null)
            {
                // throw new httpNotfound();
            }
            var resturentVm = _mapper.Map<ResturentViewModel>(resturent);

            return resturentVm;
        }
        public  Restaurant Create(CreateResturentDto dto)
        {
            var resturent = _mapper.Map<Restaurant>(dto);

             _db.Restaurants.Add(resturent);
             _db.SaveChanges();
            return resturent;
        }
        public Restaurant Update(UpdateResturentDto  dto)
        {
            var rest =  _db.Restaurants.SingleOrDefault(x => x.Id == dto.Id);

            var returentmap = _mapper.Map<Restaurant>(rest); 

             _db.Restaurants.Update(returentmap);
             _db.SaveChanges();
            return returentmap;
        }
        public int Delete(int Id) 
        {
            var restu =  _db.Restaurants.SingleOrDefault(x => x.Id == Id);
            if (restu == null)
            {
                // throw new httpNotfound();
            }
            restu.Archived = true;
            _db.Restaurants.Update(restu);
             _db.SaveChanges();
            return restu.Id;
        }

    }
}
