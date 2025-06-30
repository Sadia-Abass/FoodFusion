using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    // Dish Type - Rice, Chicken, Pasta, Seafood, etc.
    public class DishType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DishTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        //[Required]
        //public long MealTypeId { get; set; }
        //[ForeignKey(nameof(MealTypeId))]
        //public MealType? MealType { get; set; }
        public ICollection<MenuItem>? MenuItem { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
