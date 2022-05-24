using CarOLiner.Shared.ResponseModels;
using CarOLiner.UI.Components;
using CarOLiner.UI.Data.Products;
using Microsoft.AspNetCore.Components;

namespace CarOLiner.UI.Pages.Products
{
    public partial class ProductPage : ComponentBase
    {
        [Inject]
        public IProductDataService ProductDataService { get; set; }

        public List<ProductResponse> Products { get; set; }
        private ProductGrid ProductGrid { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Products = await ProductDataService.GetAllProductsAsync();
        }
    }
}
