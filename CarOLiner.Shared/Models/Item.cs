using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.Models
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string ColorName { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        // one to many relation with variants
        public List<Variant> Variants { get; set; }
    }
}
