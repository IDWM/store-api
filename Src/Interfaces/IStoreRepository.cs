using store_api.Src.DTOs.Request;
using store_api.Src.DTOs.Response;

namespace store_api.Src.Interfaces
{
    public interface IStoreRepository
    {
        Task<StoreDto> CreateStoreAsync(CreateStoreDto createStoreDto);
        Task<IEnumerable<StoreDto>> GetStoresAsync();
    }
}
