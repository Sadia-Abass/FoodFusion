using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.Auth
{
    public class ChangePasswordDTO
    {
        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        [StringLength(25, MinimumLength = 8)]
        public string NewPassword { get; set; } = String.Empty;

        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
