using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    // Meal course - Appetizers/Starters, Main Courses, Side Dishes, Desserts
    public class MealCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MealCourseId { get; set; }
        [Required]
        [StringLength(50)]
        public string MealType { get; set; } = string.Empty;
        public ICollection<MenuItem> MenuItem { get; set; } = new List<MenuItem>();
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
     
    }
}
