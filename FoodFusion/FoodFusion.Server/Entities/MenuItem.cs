﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class MenuItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long MenuItemID { get; set; }

        [Required(ErrorMessage = "Enter menu item name")]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter a Price")]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
      

        [Required]
        public long RestaurantId { get; set; }
        [ForeignKey(nameof(RestaurantId))]
        public Restaurant? Restaurant { get; set; }

        [Required]
        public long CuisineId { get; set; }
        [ForeignKey(nameof(CuisineId))]
        public Cuisine? Cuisine { get; set; }

        [Required]
        public long MealCourseId { get; set; }
        [ForeignKey(nameof(MealCourseId))]
        public MealCourse? MealCourse { get; set; }

        [Required]
        public long MealTypeId { get; set; }
        [ForeignKey(nameof(MealTypeId))]
        public MealType? MealType { get; set; } 

        [Required]
        public long DishTypeId { get; set; }
        [ForeignKey(nameof(DishTypeId))]
        public DishType? DishType { get; set; }  

        [Required]
        public long MenuItemImageId { get; set; }
        [ForeignKey(nameof(MenuItemImageId))]
        public MenuItemImage? MenuItemImage { get; set; }


        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }




    }
}
