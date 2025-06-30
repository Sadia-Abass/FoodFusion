using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    // Meal Type - Breakfast, Lunch, Dinner
    public class MealType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long MealTypeId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Category name is required")]
        public string Name { get; set; } = string.Empty;
        //[Required]
        //public long CuisineId { get; set; }
        //[ForeignKey(nameof(CuisineId))]
        //public Cuisine? Cuisine { get; set; }
        // public ICollection<DishType>? DishType { get; set; }
        public ICollection<MenuItem>? MenuItem { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
