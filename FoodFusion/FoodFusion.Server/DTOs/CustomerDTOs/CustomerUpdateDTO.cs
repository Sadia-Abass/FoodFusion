using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.DTOs.CustomerDTOs
{
    public class CustomerUpdateDTO
    {
        public long CustomerID { get; set; }
        [Required]
        public string ApplicationUserId { get; set; } = string.Empty;
        //[ForeignKey(nameof(ApplicationUserId))]
        //public virtual ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
        [Required(ErrorMessage = "Enter name")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Enter Surname")]
        [StringLength(100)]
        public string Surname { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email Address is required")]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
    }
}
