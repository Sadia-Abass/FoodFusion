using FoodFusion.Server.Entities;
using System.Security.Claims;

namespace FoodFusion.Server.Services.Interfaces
{
    public interface ITokenService
    {
        Task<string> GenerateAccessTokenAsync(ApplicationUser applicationUser);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiryToken(string token);
        Task<bool> ValidateRefreshTokenAsync(string refreshToken, string userId);
        Task RevokeRefreshTokenAsync(string userId);
        Task RevokeAllRefreshTokenAsync(string userId);
    }
}
