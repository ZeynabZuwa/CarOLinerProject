using CarOLiner.Shared.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Services.Features.Seeding
{
    public class SeedService : ISeedService
    {
        private readonly IProductRepository _productRepository;
    }
}
