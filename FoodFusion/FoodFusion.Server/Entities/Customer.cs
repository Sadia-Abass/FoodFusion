using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

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
        [Required(ErrorMessage = "Email Address is required")]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;
        public DateTime DateJoined { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public ICollection<Reservation> Reservation { get; set; } = new List<Reservation>();
    }
}
