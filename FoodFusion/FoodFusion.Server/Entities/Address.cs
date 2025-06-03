using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Address
    {
        public long AddressID { get; set; }
        [Required]
        public long CustomerID { get; set; }
        [ForeignKey(nameof(CustomerID))]
        public Customer Customer { get; set; } = new Customer();
        [Required(ErrorMessage = "Address Line 1 is required")]
        [StringLength(255)]
        public string AddressLineOne { get; set; } = string.Empty;
        [StringLength(255)]
        public string AddressLineTwo { get; set; } = string.Empty;
        [Required(ErrorMessage = "City is required")]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;
        [Required(ErrorMessage = "County is required.")]
        [StringLength(50, ErrorMessage = "County cannot exceed 50 characters.")]
        public string County { get; set; } = string.Empty;
        [Required(ErrorMessage = "Post code is required")]
        public string PostCode { get; set; } = string.Empty;       
    }
}
