using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.Auth
{
    public class ForgotPasswordDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
