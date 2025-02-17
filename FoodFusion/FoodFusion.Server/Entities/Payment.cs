using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int PaymentID { get; set; }
        [Required]
        [Column(TypeName = ("decimal(5, 2)"))]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Payment type is required")]
        public string PaymentType { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public long OrderID { get; set; }
        public Order? Order { get; set; }

    }
}
