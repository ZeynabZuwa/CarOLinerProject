using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.ResponseModels
{
    public class ItemResponse
    {
        public Guid ItemId { get; set; }
        public string ColorName { get; set; }
        public Guid ProductId { get; set; }
        public ProductResponse Product { get; set; }
        // one to many relation with variants
        public List<VariantResponse> Variants { get; set; }
    }
}
