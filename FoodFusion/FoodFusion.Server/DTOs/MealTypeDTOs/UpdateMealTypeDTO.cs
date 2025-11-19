using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.MealTypeDTOs
{
    public class UpdateMealTypeDTO
    {
        [Required]
        public long MealTypeId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Meal type name is required")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}
