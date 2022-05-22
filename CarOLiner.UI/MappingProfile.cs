using AutoMapper;
using CarOLiner.Shared.RequestModels;
using CarOLiner.Shared.ResponseModels;

namespace CarOLiner.UI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Product mapping
            CreateMap<ProductResponse, ProductRequest>();
            CreateMap<ProductRequest, ProductResponse>();

            // Item mapping
            CreateMap<ItemResponse, ItemRequest>();
            CreateMap<ItemRequest, ItemResponse>();

            // Variant mapping
            CreateMap<VariantResponse, VariantRequest>();
            CreateMap<VariantRequest, VariantResponse>();
        }
    }
}
