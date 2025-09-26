using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.Auth
{
    public class ResetPasswordDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Token { get; set; } = string.Empty;

        [Required]
        [StringLength(25, MinimumLength = 8)]
        public string NewPassword { get; set; } = string.Empty;

        [Required]
        [Compare("NewPassword")]
        public string ConfirmPassword = string.Empty;
    }
}
