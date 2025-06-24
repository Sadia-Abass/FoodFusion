using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RestaurantID { get; set; }
        [Required(ErrorMessage = "Restaurant name is required")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Address Line 1 is required")]
        [StringLength(150)]
        public string AddressLineOne { get; set; } = string.Empty;
        [Required(ErrorMessage = "Address Line 2 is required")]
        [StringLength(150)]
        public string AddressLineTwo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Town is required")]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;
        [Required(ErrorMessage = "Post code is required")]
        [StringLength(12)]
        public string PostCode { get; set; } = string.Empty;
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public long CuisineId { get; set; }
        [ForeignKey(nameof(CuisineId))]
        public Cuisine Cuisine { get; set; } = new Cuisine();
        public ICollection<MenuItem> MenuItem { get; set; } = new List<MenuItem>();
        public ICollection<Employee> Employee { get; set; } = new List<Employee>();
        public ICollection<Reservation> Reservation { get; set; } = new List<Reservation>();
    }
}
