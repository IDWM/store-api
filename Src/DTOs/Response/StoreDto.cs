using System.ComponentModel.DataAnnotations;

namespace store_api.Src.DTOs.Response
{
    public class StoreDto
    {
        public required int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string City { get; set; }
    }
}
