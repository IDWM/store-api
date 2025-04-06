using System.ComponentModel.DataAnnotations;

namespace store_api.Src.DTOs.Request
{
    public class CreateStoreDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string City { get; set; }
    }
}
