using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.DishTypeDTOs
{
    public class CreateDishTypeDTO
    {
        [Required]
        public long DishTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
    }
}
