using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.ResponseModels
{
    public class VariantResponse
    {
        public Guid VariantId { get; set; }
        public string Size { get; set; }

        public Guid ItemId { get; set; }
    }
}
