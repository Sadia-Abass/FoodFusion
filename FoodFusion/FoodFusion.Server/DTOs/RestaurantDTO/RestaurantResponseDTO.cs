using FoodFusion.Server.DTOs.CuisineDTOs;
using FoodFusion.Server.DTOs.FeedbackDTOs;
using FoodFusion.Server.DTOs.MenuItemDTOs;
using FoodFusion.Server.DTOs.ReservationResponseDTOs;
using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.RestaurantDTO
{
    public class RestaurantResponseDTO
    {
        public long RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AddressLineOne { get; set; } = string.Empty;
        public string AddressLineTwo { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int DaysOfWeek { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public int NumbersOfTables { get; set; }
        public string Logo { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public List<CuisineResponseDTO>? Cuisine { get; set; }
        public List<MenuItemResponseDTO>? MenuItem { get; set; }
        public List<ReservationResponseDTO>? Reservation { get; set; }
        public List<FeedbackResponseDTO>? Feedback { get; set; }
    }
}
