using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.MenuItemImageDTOs
{
    public class UpdateMenuItemImageDTO
    {
        [Required]
        public long MenuItemImageID { get; set; }
        [Required]
        public IFormFile ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
    }
}
