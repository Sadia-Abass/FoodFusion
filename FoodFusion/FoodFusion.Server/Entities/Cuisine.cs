using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Cuisine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CuisineID { get; set; }
        [Required(ErrorMessage = "Cuisine type is required")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Region {  get; set; } = string.Empty;
        public ICollection<MenuItem>? MenuItems { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
