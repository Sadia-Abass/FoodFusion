using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class CartItem
    {
        public long Id { get; set; }
        [Required]
        public long CartId { get; set; }
        [ForeignKey(nameof(CartId))]
        public Cart? Cart { get; set; }  
        [Required]
        public long MenuItemId { get; set; }
        [ForeignKey(nameof(MenuItemId))]
        public MenuItem? MenuItem { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Quantity must be between 1 and 20")]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.00, 250.00, ErrorMessage = "Unit Price must be between 0.00 and 250.00")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
