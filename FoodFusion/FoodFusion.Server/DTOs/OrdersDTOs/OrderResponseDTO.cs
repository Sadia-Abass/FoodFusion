using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.DTOs.OrdersDTOs
{
    public class OrderResponseDTO
    {
        public long OrderID { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public long CustomerID { get; set; }
        public long BillingAddressID { get; set; }
        public long ShippingAddressID { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal Total { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
