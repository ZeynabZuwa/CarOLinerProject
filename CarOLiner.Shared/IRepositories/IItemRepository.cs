using CarOLiner.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.IRepositories
{
    public interface IItemRepository 
    {
        Task<List<Item>> GetAllItemsAsync();
        Task<Item> GetItemsIdAsync(Guid itemId);

    }
}
