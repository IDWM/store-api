using Microsoft.AspNetCore.Mvc;
using store_api.Src.DTOs.Request;
using store_api.Src.Interfaces;

namespace store_api.Src.Controllers
{
    public class ProductController(IProductRepository productRepository) : BaseApiController
    {
        private readonly IProductRepository _productRepository = productRepository;

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            var createdProduct = await _productRepository.CreateProductAsync(createProductDto);
            return StatusCode(201, createdProduct);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}
