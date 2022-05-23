using CarOLiner.Shared.IRepositories;
using CarOLiner.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Data.Repositories
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        private readonly CarOLineDbContext _carOLineDbContext;

        public ItemRepository(CarOLineDbContext carOLineDbContext) : base(carOLineDbContext)
        {
            _carOLineDbContext = carOLineDbContext;
        }
        public async Task<List<Item>> GetAllItemsAsync()
        {
            return await _carOLineDbContext.Items
                 .Include(i => i.Variants)
                 .ToListAsync();
        }

        public async Task<Item> GetItemsIdAsync(Guid itemId)
        {
            var item = await _carOLineDbContext.Items
                .Include(i => i.Variants)
                .FirstOrDefaultAsync(i => i.ItemId == itemId);
            return item;
        }
    }
}
