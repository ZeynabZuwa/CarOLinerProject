using CarOLiner.Data;
using CarOLiner.Data.Repositories;
using CarOLiner.Services.Features.Items;
using CarOLiner.Services.Features.Products;
using CarOLiner.Services.Features.Seeding;
using CarOLiner.Services.Features.Variants;
using CarOLiner.Shared.IRepositories;
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
            //Product Services
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            //Item Services
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IItemService, ItemService>();

            //Variant Services
            services.AddScoped<IVariantRepository, VariantRepository>();
            services.AddScoped<IVariantService, VariantService>();

            // Seed Service
            services.AddScoped<ISeedService, SeedService>();

            ////Base Service
            //services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            //Mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Data Access
            services.AddDataServices(configuration);

            return services;
        }
    }
}
