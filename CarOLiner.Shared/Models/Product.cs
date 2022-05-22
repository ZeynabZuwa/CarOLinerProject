using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        //one to many relation with items
        public List<Item> Items { get; set; }
    }
}
