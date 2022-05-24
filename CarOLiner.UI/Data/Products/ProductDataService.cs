using CarOLiner.Shared.IRepositories;
using CarOLiner.Shared.ResponseModels;
using System.Net.Http;
using System.Text.Json;

namespace CarOLiner.UI.Data.Products
{
    public class ProductDataService : IProductDataService
    {
        private readonly HttpClient _httpClient;

        public ProductDataService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }




        // Metod för att skjuta mot API 
        public async Task<List<ProductResponse>> GetAllProductsAsync() 
        {


            // Hittar product routen i API:et
            var product = await _httpClient.GetAsync("product");
            // översätter allt från Jsonfilen till en List med ProductResponses
            var test = await product.Content.ReadFromJsonAsync<List<ProductResponse>>();
            return test;



        }

        
    }
}
