using CarOLiner.Shared.IRepositories;
using CarOLiner.Shared.ResponseModels;

namespace CarOLiner.UI.Data.Products
{
    public class ProductDataService : IProductDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IProductRepository _productRepository;

        public ProductDataService(HttpClient httpClient, IProductRepository productRepository)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient)); 
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public async Task<List<ProductResponse>> GetAllProducts()
        {
            var product = await _httpClient.GetAsync("Products");
            return await product.Content.ReadFromJsonAsync<List<ProductResponse>>();

        }
    }
}
