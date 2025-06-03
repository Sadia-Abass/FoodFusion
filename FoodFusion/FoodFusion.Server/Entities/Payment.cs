using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentID { get; set; }
        [Required]
        public long OrderID { get; set; }
        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; } = new Order();
        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; } = string.Empty;
        [StringLength(50)]
        public string TransactionID { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = ("decimal(18,2)"))]
        public decimal Amount { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        [StringLength(50)]
        public PaymentStatus Status { get; set; } = new PaymentStatus();
        public Refund Refund { get; set; } = new Refund();
   
    }
}
