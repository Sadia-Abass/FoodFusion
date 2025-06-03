using System.ComponentModel.DataAnnotations;

namespace FoodFusion.Server.Entities
{
    public class Status
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
