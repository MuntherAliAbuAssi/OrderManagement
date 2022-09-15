using Project.Core.Dtos;
using Project.Core.ViewModel;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastracture.Services.Resturents 
{
    public interface IResturentService 
    { 
        ResturentViewModel Get(int Id);
        Restaurant Create(CreateResturentDto dto);
        Restaurant Update(UpdateResturentDto dto); 
        int Delete(int Id);
    }
}
