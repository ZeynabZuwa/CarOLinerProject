using AutoMapper;
using CarOLiner.Shared.Models;
using CarOLiner.Shared.RequestModels;
using CarOLiner.Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOLiner.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping for Product
            CreateMap<Product, ProductResponse>().ReverseMap();
            CreateMap<ProductRequest, Product>().ReverseMap();
            CreateMap<ProductRequest, ProductResponse>().ReverseMap();

            // Mapping for Item
            CreateMap<Item, ItemResponse>().ReverseMap();
            CreateMap<ItemRequest, Item>().ReverseMap();
            CreateMap<ItemRequest, ItemResponse>().ReverseMap();

            // Mapping for Variant
            CreateMap<Variant, VariantResponse>().ReverseMap();
            CreateMap<VariantRequest, Variant>().ReverseMap();
            CreateMap<VariantRequest, VariantResponse>().ReverseMap();
        }
    }
}
