using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Refund
    {
        public long RefundId { get; set; }
        [Required(ErrorMessage = "Cancellation ID is required.")]
        public long CancellationId { get; set; }
        [ForeignKey(nameof(CancellationId))]
        public Cancellation Cancellation { get; set; } = new Cancellation();
        [Required(ErrorMessage = "Payment ID is required.")]
        public long PaymentId { get; set; }
        [ForeignKey(nameof(PaymentId))]
        public Payment Payment { get; set; } = new Payment();
        [Column(TypeName  = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [Required]
        public RefundStatus Status { get; set; }
        [Required]
        public string RefundMethod { get; set; } = string.Empty;
        [StringLength(500, ErrorMessage = "Refund reason cannot exceed 500 characters.")]
        public string RefundReason { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        [Required]
        public DateTime InitiatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public long ProcessedBy { get; set; }
    }
}
