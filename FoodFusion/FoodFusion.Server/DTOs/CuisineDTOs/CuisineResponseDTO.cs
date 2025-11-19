using FoodFusion.Server.DTOs.MenuItemDTOs;
using FoodFusion.Server.DTOs.RestaurantDTO;
using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.CuisineDTOs
{
    public class CuisineResponseDTO
    {
        public long CuisineID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public List<MenuItemResponseDTO>? MenuItems { get; set; }
        public List<RestaurantResponseDTO>? Restaurants { get; set; } 
    }
}
