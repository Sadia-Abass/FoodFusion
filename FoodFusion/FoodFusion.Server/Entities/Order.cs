using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderID { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Order Number cannot exceed 30 characters.")]
        public string OrderNumber { get; set; } = string.Empty;

        [Required]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Customer ID is required")]
        public long CustomerID { get; set; }

        [ForeignKey(nameof(CustomerID))]   
        public Customer Customer { get; set; } = new Customer();

        [Required(ErrorMessage = "Billing Address ID is required.")]
        public long BillingAddressID {  get; set; }

        [ForeignKey(nameof(BillingAddressID))]
        public Address BillingAddress { get; set; } = new Address();

        [Required(ErrorMessage = "Shipping Address ID is required.")]
        public long ShippingAddressID { get; set; }

        [ForeignKey(nameof(ShippingAddressID))]
        public Address ShippingAddress { get; set; } = new Address();

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DeliveryFee { get; set; }

        [Column(TypeName = ("decimal(18,2)"))]
        public decimal Total { get; set; }

        [Required]
        [EnumDataType(typeof(OrderStatus), ErrorMessage = "Invalid Order Status.")]
        public OrderStatus OrderStatus { get; set; }

        [Required]
        public ICollection<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Payment Payment { get; set; }  = new Payment();
        public Cancellation Cancellation { get; set; } = new Cancellation();
    }
}
