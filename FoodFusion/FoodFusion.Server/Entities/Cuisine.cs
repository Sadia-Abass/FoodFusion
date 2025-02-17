using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Cuisine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long CuisineID { get; set; }
        [Required(ErrorMessage = "Cuisine type is required")]
        [StringLength(50)]
        public string Type { get; set; } = string.Empty;
        public List<Category> Categories { get; set; } = new List<Category>();
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
