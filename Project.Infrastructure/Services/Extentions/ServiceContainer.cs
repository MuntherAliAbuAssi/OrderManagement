using Microsoft.Extensions.DependencyInjection;
using Project.Infrastracture.Services.Resturents;
using Project.Infrastructure.Services.CSV;
using Project.Infrastructure.Services.Customers;
using Project.Infrastructure.Services.Orderd;
using Project.Infrastructure.Services.ResturentMenu;
using Project.Infrastructure.Services.Resturents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Services.Extentions
{
    public static class ServiceContainer 
    {  
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IResturentService, ResturentService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IResturentMenuService, ResturentMenuService>();
            services.AddTransient<ICsvService, CsvService>();
            return services;
        }
    }
}
