using Project.Core.Dtos;
using Project.Core.ViewModel;
using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Services.Customers 
{
    public interface ICustomerService 
    {
        CustomerViewModel Get(int Id);
        Customer Create(CreateCustomerDto dto);
        Customer Update(UpdateCustomerDto dto);
        int Delete(int Id);
    }
}
