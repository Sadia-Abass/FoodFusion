using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.Auth
{
    public class RegisterDto
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(25, ErrorMessage = "the {0} must be at least {1} characters long.", MinimumLength = 8)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [StringLength(25, ErrorMessage = "the {0} must be at least {1} characters long.",  MinimumLength = 8)]
        public string? ConfirmPassword { get; set; }
    }
}
