using CarOLiner.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.IRepositories
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductIdAsync(Guid productId);
    }
}
