using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CustomerID { get; set; }
        [Required]
        public string ApplicationUserId { get; set; } = string.Empty;
        [ForeignKey(nameof(ApplicationUserId))]
        public virtual ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
        [Required(ErrorMessage = "Enter name")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Enter Surname")]
        [StringLength(100)]
        public string Surname { get; set; } = string.Empty;
        [Required(ErrorMessage = "Address Line 1 is required")]
        [StringLength(255)]
        public string AddressLineOne { get; set; } = string.Empty;
        [StringLength(255)]
        public string AddressLineTwo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Town is required")]
        [StringLength(100)]
        public string Town { get; set; } = string.Empty;
        [Required(ErrorMessage = "Post code is required")]
        public string PostCode { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email Address is required")]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
