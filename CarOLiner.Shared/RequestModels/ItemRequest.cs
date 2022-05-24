using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.RequestModels
{
    public class ItemRequest
    {
        public Guid ItemId { get; set; }
        public string ColorName { get; set; }
        public Guid ProductId { get; set; }
        // one to many relation with variants
        public List<VariantRequest> Variants { get; set; }
    }
}
