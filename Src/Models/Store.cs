using System.ComponentModel.DataAnnotations;

namespace store_api.Src.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string City { get; set; }

        public List<Product> Products { get; set; } = [];
    }
}
