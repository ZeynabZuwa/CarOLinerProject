using CarOLiner.Shared.RequestModels;
using CarOLiner.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Services.Features.Products
{
    public interface IProductService
    {
        Task<List<ProductResponse>> GetAllProducts();
        Task<ProductResponse> GetProductById(Guid productId);
        Task<ProductResponse> DeleteProduct(Guid productId);
        Task<ProductResponse> UpdateProduct(ProductRequest productRequest);
    }
}
