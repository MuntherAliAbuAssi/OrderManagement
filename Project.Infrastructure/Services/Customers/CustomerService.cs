using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project.Core.Dtos;
using Project.Core.ViewModel;
using Project.Data;
using Project.Data.Models;
using Project.Infrastructure.Services.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Services.Customers 
{
    public class CustomerService : ICustomerService
    {  
        private readonly ProjectsContext _db;
        private readonly IMapper _mapper;
        public CustomerService(ProjectsContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public CustomerViewModel Get(int Id)
        {
            var customer =  _db.Customers.SingleOrDefault(x => x.Id == Id);
            if (customer == null)
            {
                // throw new httpNotfound();
            }
            var customersVm = _mapper.Map<CustomerViewModel>(customer);

            return customersVm;
        }
        public Customer Create(CreateCustomerDto dto)           
        {          
            var customer = _mapper.Map<Customer>(dto);
            customer.FirstName = Captlaize.NameCapital(dto.FirstName);
             _db.Customers.Add(customer);
             _db.SaveChanges();
            return customer;
        }
        public Customer Update(UpdateCustomerDto dto)
        {
            var customer =  _db.Customers.SingleOrDefault(x => x.Id == dto.Id);

            var customerMap = _mapper.Map<Customer>(customer);

            _db.Customers.Update(customerMap);
             _db.SaveChanges();
            return customerMap;
        }
        public int Delete(int Id)
        { 
            var customer =  _db.Customers.SingleOrDefault(x => x.Id == Id);
            if (customer == null)
            {
                // throw new httpNotfound();
            }
            customer.Archived = true;
            _db.Customers.Update(customer);
             _db.SaveChanges();
            return customer.Id;
        }
    }
}
