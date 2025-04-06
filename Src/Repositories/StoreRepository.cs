using AutoMapper;
using store_api.Src.Data;
using store_api.Src.DTOs.Request;
using store_api.Src.DTOs.Response;
using store_api.Src.Interfaces;
using store_api.Src.Models;

namespace store_api.Src.Repositories
{
    public class StoreRepository(DataContext dataContext, IMapper mapper) : IStoreRepository
    {
        private readonly DataContext _dataContext = dataContext;
        private readonly IMapper _mapper = mapper;

        public async Task<StoreDto> CreateStoreAsync(CreateStoreDto createStoreDto)
        {
            var store = _mapper.Map<Store>(createStoreDto);

            await _dataContext.Stores.AddAsync(store);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<StoreDto>(store);
        }
    }
}
