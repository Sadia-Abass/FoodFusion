using Microsoft.Identity.Client;

namespace FoodFusion.Server.Configurations
{
    public class JwtSettings
    {
        //public JwtSettings() 
        //{
        //    Key = "A_KEY";
        //    Issuer = "https://localhost:nnnn";
        //    Audience = "Audience";
        //    MinutesToExpiration = 30;
        //}

        public string? Key { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
        public int MinutesToExpiration { get; set; }
    }
}
