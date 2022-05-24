using AutoMapper;
using CarOLiner.Shared.IRepositories;
using CarOLiner.Shared.RequestModels;
using CarOLiner.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Services.Features.Products
{
   
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<ProductResponse>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProductsAsync();
            var productResponses = _mapper.Map<List<ProductResponse>>(products);
            return productResponses;
        }

        public async Task<ProductResponse> GetProductById(Guid productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            var productResponse = _mapper.Map<ProductResponse>(product);
            return productResponse;
        }

        public async Task<ProductResponse> DeleteProduct(Guid productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            await _productRepository.DeleteAsync(product);
            var productResponse = _mapper.Map<ProductResponse>(product);
            return productResponse;
        }

        public async Task<ProductResponse> UpdateProduct(ProductRequest productRequest)
        {
            var productFromDb = await _productRepository.GetByIdAsync(productRequest.ProductId);

            if(productFromDb != null)
            {
                productFromDb.ProductName = productRequest.ProductName;
                await _productRepository.UpdateAsync(productFromDb);
            }
            return _mapper.Map<ProductResponse>(productRequest);

        }
    }
}
