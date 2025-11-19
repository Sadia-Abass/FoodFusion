using FoodFusion.Server.DTOs.MenuItemDTOs;
using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.MealTypeDTOs
{
    public class MealTypeResponseDTO
    {
        public long MealTypeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public List<MenuItemResponseDTO>? MenuItems { get; set; }
    }
}
