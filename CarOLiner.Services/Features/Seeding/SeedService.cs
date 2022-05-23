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
                ProductId = Dress.ProductId,
                Variants = new List<Variant>()
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
                ProductId = Dress.ProductId,
                Variants = new List<Variant>()
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

            
            
            var Shirt = new Product()
            {
                ProductId = Guid.NewGuid(),
                ProductName = "Shirt",
                Items = new List<Item>()
            };
            var ShirtItems = new List<Item>();

            var ShirtItemBlue = new Item()
            {
                ItemId = Guid.NewGuid(),
                ColorName = "Blue",
                ProductId = Shirt.ProductId,
                Variants = new List<Variant>()
            };

            var ShirtItemBlueVariants = new List<Variant>()
            {
                new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "M",
                    ItemId = ShirtItemBlue.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "L",
                    ItemId = ShirtItemBlue.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "XL",
                    ItemId = ShirtItemBlue.ItemId

                }
            };


            var ShirtItemYellow = new Item()
            {
                ItemId = Guid.NewGuid(),
                ColorName = "Yellow",
                ProductId = Shirt.ProductId,
                Variants = new List<Variant>()
            };

            var ShirtItemYellowVariants = new List<Variant>()
            {
                new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "L",
                    ItemId = ShirtItemYellow.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "XL",
                    ItemId = ShirtItemYellow.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "XXL",
                    ItemId = ShirtItemYellow.ItemId

                }
            };

            ShirtItemBlue.Variants.AddRange(ShirtItemBlueVariants);
            ShirtItemYellow.Variants.AddRange(ShirtItemYellowVariants);

            ShirtItems.Add(ShirtItemBlue);
            ShirtItems.Add(ShirtItemYellow);

            Shirt.Items.AddRange(ShirtItems);

            await _productRepository.AddAsync(Shirt);

            
            
            var Pants = new Product()
            {
                ProductId = Guid.NewGuid(),
                ProductName = "Pants",
                Items = new List<Item>()
            };
            var PantsItems = new List<Item>();

            var PantsItemPurple = new Item()
            {
                ItemId = Guid.NewGuid(),
                ColorName = "Purple",
                ProductId = Pants.ProductId,
                Variants = new List<Variant>()
            };

            var PantsItemPurpleVariants = new List<Variant>()
            {
                new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "M",
                    ItemId = PantsItemPurple.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "L",
                    ItemId = PantsItemPurple.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "XL",
                    ItemId = PantsItemPurple.ItemId

                }
            };


            var PantsItemOrange = new Item()
            {
                ItemId = Guid.NewGuid(),
                ColorName = "Orange",
                ProductId = Pants.ProductId,
                Variants = new List<Variant>()
            };

            var PantsItemOrangeVariants = new List<Variant>()
            {
                new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "XS",
                    ItemId = PantsItemOrange.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "S",
                    ItemId = PantsItemOrange.ItemId

                },
                   new Variant()
                {
                    VariantId = Guid.NewGuid(),
                    Size = "M",
                    ItemId = PantsItemOrange.ItemId

                }
            };

            PantsItemOrange.Variants.AddRange(PantsItemOrangeVariants);
            PantsItemPurple.Variants.AddRange(PantsItemPurpleVariants);

            PantsItems.Add(PantsItemOrange);
            PantsItems.Add(PantsItemPurple);

            Pants.Items.AddRange(PantsItems);

            await _productRepository.AddAsync(Pants);





        }
    }
}
