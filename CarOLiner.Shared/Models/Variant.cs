using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.Models
{
    public class Variant
    {
        public Guid VariantId { get; set; }
        public string Size { get; set; }

        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
