using FoodFusion.Server.DTOs.MenuItemImageDTOs;
using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.DTOs.MenuItemDTOs
{
    public class MenuItemListDTO
    {
        public long MenuItemID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public int PreparationTimeInMinutes { get; set; }
        public string Allergens { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;
        public string CuisineName {  get; set; } = string.Empty;
        public string MealCourseName {  get; set; } = string.Empty;

        public List<string>? DishTypeNames { get; set; }
        public MenuItemImageResponseDTO? MenuItemImage { get; set; }
    }
}
