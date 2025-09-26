using Microsoft.Identity.Client;

namespace FoodFusion.Server.DTOs.Auth
{
    public class TokenResponseDTO
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken {  get; set; } = string.Empty;
        public DateTime TokenExpiry { get; set; }
        public ApplicationUserDTO User { get; set; } = new();
    }
}
