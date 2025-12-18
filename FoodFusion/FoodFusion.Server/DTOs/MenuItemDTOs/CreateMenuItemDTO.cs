using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.DTOs.MenuItemDTOs
{
    public class CreateMenuItemDTO
    {
        [Required(ErrorMessage = "Enter menu item name")]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter a Price")]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

        public int Calories { get; set; }

        public int PreparationTimeInMinutes { get; set; }

        [MaxLength(500)]
        public string Allergens { get; set; } = string.Empty;

        public IFormFile? ImageUrl { get; set; }
        public bool IsAvailable { get; set; }

        [Required]
        public long RestaurantId { get; set; }

        [Required]
        public long CuisineId { get; set; }

        [Required]
        public long MealCourseId { get; set; }

        [Required]
        public long MealTypeId { get; set; }
        [Required]
        public long MenuItemImageId { get; set; }

       public List<int>? DishTypeIds { get; set; }
    }
}
