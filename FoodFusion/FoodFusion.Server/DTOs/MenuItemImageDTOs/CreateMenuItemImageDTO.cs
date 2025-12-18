using FoodFusion.Server.Entities;

namespace FoodFusion.Server.DTOs.MenuItemImageDTOs
{
    public class CreateMenuItemImageDTO
    {
        public IFormFile ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
    }
}
