using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.RestaurantDTO
{
    public class CreateRestaurantDTO
    {

        [Required(ErrorMessage = "Restaurant name is required")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address Line 1 is required")]
        [StringLength(150)]
        public string AddressLineOne { get; set; } = string.Empty;

        [StringLength(150)]
        public string AddressLineTwo { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required")]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Post code is required")]
        [StringLength(12)]
        public string PostCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Number of Day of week open is required.")]
        public int DaysOfWeek { get; set; }

        [Required(ErrorMessage = "Opening time is required")]
        public TimeSpan OpeningTime { get; set; }

        [Required(ErrorMessage = "Closing time is required")]
        public TimeSpan ClosingTime { get; set; }

        [Required(ErrorMessage = "Numbers of available tables is required.")]
        public int NumbersOfTables { get; set; }

        public IFormFile? Logo { get; set; } 
    }
}
