using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Cart
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer? Customer { get; set; }
        public bool IsCheckedOut { get; set; } = false;
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime LastUpdatedDate { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
    }
}
