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
        public long SubCategoryID { get; set; }
        public SubCategory? SubCategory { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
