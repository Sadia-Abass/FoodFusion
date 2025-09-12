using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.DTOs.AddressesDTOs
{
    public class AddressDeleteDTO
    {
        [Required(ErrorMessage = "AddressId is required.")]
        public long AddressID { get; set; }

        [Required(ErrorMessage = "CustomerId is required.")]
        public long CustomerID { get; set; }
    }
}
