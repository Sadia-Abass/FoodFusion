using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.CuisineDTOs
{
    public class CreateCuisineDTO
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Region { get; set; } = string.Empty;
    }
}
