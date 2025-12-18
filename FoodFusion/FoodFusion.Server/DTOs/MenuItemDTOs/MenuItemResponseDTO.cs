using FoodFusion.Server.DTOs.CuisineDTOs;
using FoodFusion.Server.DTOs.DishTypeDTOs;
using FoodFusion.Server.DTOs.MealCourseDTOs;
using FoodFusion.Server.DTOs.MealTypeDTOs;
using FoodFusion.Server.DTOs.MenuItemImageDTOs;
using FoodFusion.Server.DTOs.RestaurantDTO;
using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.DTOs.MenuItemDTOs
{
    public class MenuItemResponseDTO
    {
        public long MenuItemID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public int PreparationTimeInMinutes { get; set; }
        public string Allergens { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;

        public RestaurantResponseDTO? Restaurant { get; set; }
        public CuisineResponseDTO? Cuisine { get; set; }
        public MealCourseResponseDTO? MealCourse { get; set; }
        public MealTypeResponseDTO? MealType { get; set; }
        public List<DishTypeResponseDTO>? DishTypes { get; set; }
        public MenuItemImageResponseDTO? MenuItemImage { get; set; }
    }
}
