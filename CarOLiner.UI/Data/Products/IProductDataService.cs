using CarOLiner.Shared.ResponseModels;

namespace CarOLiner.UI.Data.Products
{
    public interface IProductDataService
    {
        Task<List<ProductResponse>> GetAllProductsAsync();
    }
}
