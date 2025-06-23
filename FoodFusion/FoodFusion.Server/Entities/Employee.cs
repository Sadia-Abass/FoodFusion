using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EmployeeID { get; set; }
        [Required]
        public string ApplicationUserId { get; set; } = string.Empty;
        [ForeignKey(nameof(ApplicationUserId))]
        public virtual ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Surname is required")]
        [StringLength(100)]
        public string Surname { get; set; } = string.Empty;
        [Required(ErrorMessage = "Address line 1 is required")]
        [StringLength(255)]
        public string AddressLineOne { get; set; } = string.Empty;
        [StringLength(255)]
        public string AddressLineTwo { get; set;} = string.Empty;
        [Required(ErrorMessage = "City is required")]
        [StringLength(50)]
        public string City { get; set; } = string.Empty;
        [Required(ErrorMessage = "Postcode is reqired")]
        [StringLength(12)]
        public string PostCode { get; set; } = string.Empty;
        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(11)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required(ErrorMessage = ("Role is required"))]
        [StringLength(50)]
        public string JobRole { get; set; } = string.Empty;
        [Required]
        public long RestaurantId { get; set; }
        [ForeignKey(nameof(RestaurantId))]
        public Restaurant Restaurant { get; set; } = new Restaurant();
        public DateTime HireDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
