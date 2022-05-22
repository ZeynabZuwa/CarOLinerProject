using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.RequestModels
{
    public class ProductRequest
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public List<ItemRequest> Items { get; set; }
    }
}
