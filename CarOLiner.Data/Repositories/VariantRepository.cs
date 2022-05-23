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
    public class VariantRepository : BaseRepository<Variant>, IVariantRepository
    {
        private readonly CarOLineDbContext _carOLineDbContext;

        public VariantRepository(CarOLineDbContext carOLineDbContext) : base(carOLineDbContext)
        {
            _carOLineDbContext = carOLineDbContext;
        }

        public async Task<List<Variant>> GetAllVariantsAsync()
        {
            return await _carOLineDbContext.Variants
                 .ToListAsync();
        }

        public async Task<Variant> GetItemsIdAsync(Guid variantId)
        {
            var variant = await _carOLineDbContext.Variants
                .FirstOrDefaultAsync(v => v.VariantId == variantId);
            return variant;
        }
    }
}
