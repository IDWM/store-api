using System.ComponentModel.DataAnnotations;

namespace store_api.Src.DTOs.Response
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }

        [Required]
        [Range(1, 100000)]
        public required float Price { get; set; }
    }
}
