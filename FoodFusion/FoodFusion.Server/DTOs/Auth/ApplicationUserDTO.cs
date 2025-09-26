namespace FoodFusion.Server.DTOs.Auth
{
    public class ApplicationUserDTO
    {
        public long Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
    }
}
