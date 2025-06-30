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
        public string Type { get; set; } = string.Empty;  

        public ICollection<MenuItem>? MenuItem { get; set; }
        public ICollection<Restaurant> Restaurant { get; set; } = new List<Restaurant>();
        //public ICollection<MealType> MealType { get; set; } = new List<MealType>();

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
