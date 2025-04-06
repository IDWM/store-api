using store_api.Src.DTOs.Request;
using store_api.Src.DTOs.Response;

namespace store_api.Src.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto);
        Task<ProductDto?> GetProductByIdAsync(int id);
    }
}
