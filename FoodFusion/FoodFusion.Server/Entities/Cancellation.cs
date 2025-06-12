using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Cancellation
    {
        public long CancellationId { get; set; }
        [Required(ErrorMessage = "Order ID is required.")]
        public long OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = new Order();
        [Required(ErrorMessage = "Cancellation reason is required.")]
        [StringLength(500, ErrorMessage = "Cancellation reason cannot exceed 500 characters")]
        public string Reason { get; set; } = string.Empty;
        [Required]
        public CancellationStatus Status { get; set; }
        [Required]
        public DateTime CancellationRequestedDate { get; set; }
        public DateTime CancellationProcessedDate { get; set; }
        public long ProcessedBy { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderAmount { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(18,2)")]
        public decimal CancellationCharges { get; set; } = decimal.Zero;
        [StringLength(500, ErrorMessage = "Comments cannot exceed 500 characters")]
        public string Comment { get; set; } = string.Empty;
        public Refund Refund { get; set; } = new Refund();
    }
}
