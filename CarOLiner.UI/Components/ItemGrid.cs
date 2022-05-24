using CarOLiner.Shared.ResponseModels;
using CarOLiner.UI.Data.Items;
using Microsoft.AspNetCore.Components;

namespace CarOLiner.UI.Components
{
    public partial class ItemGrid : ComponentBase
    {
        [Inject]
        public IItemDataService ItemDataService { get; set; }

        [Parameter]
        public List<ItemResponse> Items { get; set; }
        private ItemResponse selectedItem { get; set; }

        private VariantGrid VariantGrid { get; set; }
    }
}
