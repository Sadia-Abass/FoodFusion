using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderItemID { get; set; }
        public long OrderID { get; set; }
        public Order Order { get; set; } = new Order();
        public long MenuItemID { get; set; }
        public MenuItem MenuItem { get; set; } = new MenuItem();
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal PriceAtOrder { get; set; }
    }
}
