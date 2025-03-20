using Microsoft.AspNetCore.Identity;

namespace FoodFusion.Server.Entities
{
    public class ApplicationUser : IdentityUser 
    {
        public string UserType { get; set; } = string.Empty;

        public virtual Customer Customer { get; set; } = new Customer();
        public virtual Employee Employee { get; set; } = new Employee();
    }
}
