using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.MealCourseDTOs
{
    public class MealCourseResponseDTO
    {
        public long MealCourseId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public List<MenuItemResponseDTO>? MenuItems { get; set; }
    }
}
