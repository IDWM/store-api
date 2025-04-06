using System.ComponentModel.DataAnnotations;

namespace store_api.Src.DTOs.Request
{
    public class CreateProductDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }

        [Required]
        [Range(1, 100000)]
        public required float Price { get; set; }

        public required int StoreId { get; set; }
    }
}
