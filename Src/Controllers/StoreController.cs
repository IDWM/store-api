using Microsoft.AspNetCore.Mvc;
using store_api.Src.DTOs.Request;
using store_api.Src.Interfaces;

namespace store_api.Src.Controllers
{
    public class StoreController(IStoreRepository storeRepository) : BaseApiController
    {
        private readonly IStoreRepository _storeRepository = storeRepository;

        [HttpPost]
        public async Task<IActionResult> CreateStore([FromBody] CreateStoreDto createStoreDto)
        {
            var createdStore = await _storeRepository.CreateStoreAsync(createStoreDto);
            return StatusCode(201, createdStore);
        }

        [HttpGet]
        public async Task<IActionResult> GetStores()
        {
            var stores = await _storeRepository.GetStoresAsync();
            return Ok(stores);
        }
    }
}
