using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.DTOs.ReservationResponseDTOs
{
    public class ReservationResponseDTO
    {
        public long ReservationID { get; set; }
        public long CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerPhonenumber { get; set; } = string.Empty;
        public DateTime ReservationDate { get; set; }
        public DateTime ReservationTime { get; set; }
        public int NumberOfPeople { get; set; }
        public string SpecialRequests { get; set; } = string.Empty;
        public long RestaurantId { get; set; }
    }
}
