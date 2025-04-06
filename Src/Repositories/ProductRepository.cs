using AutoMapper;
using store_api.Src.Data;
using store_api.Src.DTOs.Request;
using store_api.Src.DTOs.Response;
using store_api.Src.Interfaces;
using store_api.Src.Models;

namespace store_api.Src.Repositories
{
    public class ProductRepository(DataContext dataContext, IMapper mapper) : IProductRepository
    {
        private readonly DataContext _dataContext = dataContext;
        private readonly IMapper _mapper = mapper;

        public async Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto)
        {
            var store =
                await _dataContext.Stores.FindAsync(createProductDto.StoreId)
                ?? throw new Exception("Store not found");

            var product = _mapper.Map<Product>(createProductDto, opt => opt.Items["Store"] = store);

            await _dataContext.Products.AddAsync(product);
            await _dataContext.SaveChangesAsync();

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await _dataContext.Products.FindAsync(id);

            return _mapper.Map<ProductDto>(product);
        }
    }
}
