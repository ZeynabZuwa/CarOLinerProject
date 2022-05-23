using CarOLiner.Shared.IRepositories;
using CarOLiner.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly CarOLineDbContext _carOLineDbContext;
        public ProductRepository(CarOLineDbContext carOLineDbContext) : base(carOLineDbContext)
        {
            _carOLineDbContext = carOLineDbContext;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
           return await _carOLineDbContext.Products
                .Include(p => p.Items)
                .ThenInclude(i => i.Variants)
                .ToListAsync();
        }

        public async Task<Product> GetProductIdAsync(Guid productId)
        {
            var product = await _carOLineDbContext.Products
                .Include(p => p.Items)
                .ThenInclude(i => i.Variants)
                .FirstOrDefaultAsync(p => p.ProductId == productId);
            return product;
        }
    }
}
