using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFusion.Server.Entities
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReservationID { get; set; } 
        public long CustomerID { get; set; }
        public Customer Customer { get; set; } = new Customer();
        [Required]
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerPhonenumber { get; set; } = string.Empty;
        [Required(ErrorMessage = "Reservation date is required")]
        public DateTime ReservationDate { get; set; }
        [Required(ErrorMessage = "Reservation time is required")]
        public DateTime ReservationTime { get; set;}
        [Required(ErrorMessage = "Number of people is required")]
        public int NumberOfPeople { get; set; }
        [StringLength(255)]
        public string SpecialRequests { get; set; } = string.Empty;
    }
}
