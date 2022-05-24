using CarOLiner.Shared.ResponseModels;
using CarOLiner.UI.Data.Products;
using Microsoft.AspNetCore.Components;

namespace CarOLiner.UI.Components
{
    public partial class ProductGrid : ComponentBase
    {
        [Inject]
        public IProductDataService ProductDataService { get; set; }

        [Parameter]
        public List<ProductResponse> ProductsResponses { get; set; }
        private ProductResponse selectedProduct { get; set; }

        private ItemGrid ItemGrid { get; set; }
    }
}
