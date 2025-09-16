using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.DTOs.FeedbackDTOs
{
    public class FeedbackResponseDTO
    {
        public long FeedbackId { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public long RestaurantId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}
