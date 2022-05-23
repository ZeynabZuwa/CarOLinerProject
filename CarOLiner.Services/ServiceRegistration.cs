using CarOLiner.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            ////Product Services
            //services.AddScoped<IOrderRepository, OrderRepository>();
            //services.AddScoped<IOrderService, OrderService>();

            ////Item Services
            //services.AddScoped<IOrderRepository, OrderRepository>();
            //services.AddScoped<IOrderService, OrderService>();

            ////Variant Services
            //services.AddScoped<IOrderRepository, OrderRepository>();
            //services.AddScoped<IOrderService, OrderService>();

            //Mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Data Access
            services.AddDataServices(configuration);

            return services;
        }
    }
}
