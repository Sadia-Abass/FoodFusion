using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.MenuItemImageDTOs
{
    public class MenuItemImageResponseDTO
    {
        public long MenuItemImageID { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public long MenuItemID { get; set; }
    }
}
