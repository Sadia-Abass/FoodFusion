using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.AddressesDTOs
{
    public class AddressCreateDTO
    {
        [Required(ErrorMessage = "CustomerId is required.")]
        public long CustomerID { get; set; }

        [Required(ErrorMessage = "Address line 1 is required.")]
        [StringLength(255, ErrorMessage = "Address Line 1 cannot exceed 255 characters.")]
        public string AddressLineOne { get; set; } = string.Empty;

        [StringLength(255, ErrorMessage = "Address Line 2 cannot exceed 255 characters.")]
        public string AddressLineTwo { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required")]
        [StringLength(100, ErrorMessage = "City cannot exceed 100 characters.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "County is required.")]
        [StringLength(50, ErrorMessage = "County cannot exceed 50 characters.")]
        public string County { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postcode is required")]
        [RegularExpression(@"^[A-Z]{1,2}[0-9R][0-9A-Z]?●[0-9][ABD-HJLNP-UW-Z]{2}$", ErrorMessage = "Invalid Postcode")]
        public string PostCode { get; set; } = string.Empty;
    }
}
