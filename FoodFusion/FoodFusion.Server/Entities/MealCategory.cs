using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class MealCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long MealCategoryId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Category name is required")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public long CuisineId { get; set; }
        [ForeignKey(nameof(CuisineId))]
        public Cuisine? Cuisine { get; set; }
        public ICollection<DishType>? DishType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
