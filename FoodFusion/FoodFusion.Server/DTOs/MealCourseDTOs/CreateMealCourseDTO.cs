using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.MealCourseDTOs
{
    public class CreateMealCourseDTO
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
    }
}
