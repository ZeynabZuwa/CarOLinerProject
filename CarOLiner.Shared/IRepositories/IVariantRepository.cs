﻿using CarOLiner.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Shared.IRepositories
{
    public interface IVariantRepository : IAsyncRepository<Variant>
    {
        Task<List<Variant>> GetAllVariantsAsync();
        Task<Variant> GetItemsIdAsync(Guid variantId);

    }
}
