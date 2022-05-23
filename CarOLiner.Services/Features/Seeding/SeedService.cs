using CarOLiner.Shared.IRepositories;
using CarOLiner.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Services.Features.Seeding
{
    public class SeedService : ISeedService
    {
        private readonly IProductRepository _productRepository;

        public SeedService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task SeedDatabaseAsync()
        {
            var Dress = new Product()
            {
                ProductId = Guid.NewGuid(),
                ProductName = "Dress",
                Items = new List<Item>()
            };
            var DressItems = new List<Item>();

            var DressItemRed = new Item()
            {
                ItemId = Guid.NewGuid(),
                ColorName = "Red",
                ProductId = Dress.ProductId
            };

            var DressItemRedVariants = new List<Variant>()
            {
                new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "S",
                    ItemId = DressItemRed.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "M",
                    ItemId = DressItemRed.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "L",
                    ItemId = DressItemRed.ItemId

                }
            };


            var DressItemGreen = new Item()
            {
                ItemId = Guid.NewGuid(),
                ColorName = "Green",
                ProductId = Dress.ProductId
            };

            var DressItemGreenVariants = new List<Variant>()
            {
                new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "S",
                    ItemId = DressItemGreen.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "M",
                    ItemId = DressItemGreen.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "L",
                    ItemId = DressItemGreen.ItemId

                }
            };

            DressItemGreen.Variants.AddRange(DressItemGreenVariants);
            DressItemRed.Variants.AddRange(DressItemRedVariants);

            DressItems.Add(DressItemGreen);
            DressItems.Add(DressItemRed);

            Dress.Items.AddRange(DressItems);

            await _productRepository.AddAsync(Dress);





        }
    }
}
