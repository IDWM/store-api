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
            // Map from CreateStoreDto to Store
            CreateMap<CreateStoreDto, Store>();

            // Map from Store to StoreDto
            CreateMap<Store, StoreDto>();
        }
    }
}
