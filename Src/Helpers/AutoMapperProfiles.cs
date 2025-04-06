using AutoMapper;
using store_api.Src.DTOs.Request;
using store_api.Src.DTOs.Response;
using store_api.Src.Models;

namespace store_api.Src.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CreateStoreDto, Store>();
            CreateMap<Store, StoreDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>()
                .ForMember(dest => dest.Store, opt => opt.Ignore())
                .ForMember(dest => dest.StoreId, opt => opt.MapFrom(src => src.StoreId));
        }
    }
}
