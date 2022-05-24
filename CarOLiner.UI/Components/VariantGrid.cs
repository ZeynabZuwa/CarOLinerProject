using CarOLiner.Shared.ResponseModels;
using CarOLiner.UI.Data.Variants;
using Microsoft.AspNetCore.Components;

namespace CarOLiner.UI.Components
{
    public partial class VariantGrid
    {
        [Inject]
        public IVariantDataService VariantDataService { get; set; }

        [Parameter]
        public List<VariantResponse> Variants { get; set; }

        private VariantResponse selectedVariant { get; set; }
    }
}
