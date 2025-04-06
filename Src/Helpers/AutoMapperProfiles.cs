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
        }
    }
}
