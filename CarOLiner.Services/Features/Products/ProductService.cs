using AutoMapper;
using CarOLiner.Shared.IRepositories;
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
    }
}
