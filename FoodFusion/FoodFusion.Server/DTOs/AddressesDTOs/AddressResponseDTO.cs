using FoodFusion.Server.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.DTOs.AddressesDTOs
{
    public class AddressResponseDTO
    {
        public long Id { get; set; }
        public long CustomerID { get; set; }
        public string AddressLineOne { get; set; } = string.Empty;
        public string AddressLineTwo { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string County { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
    }
}
