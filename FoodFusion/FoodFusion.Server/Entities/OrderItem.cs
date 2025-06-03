using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderItemID { get; set; }
        [Required(ErrorMessage = "Order ID is required")]
        public long OrderID { get; set; }
        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; } = new Order();
        [Required(ErrorMessage = "Menu item ID is required")]
        public long MenuItemID { get; set; }
        [ForeignKey(nameof(MenuItemID))]
        public MenuItem MenuItem { get; set; } = new MenuItem();
        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100.")]
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
    }
}
