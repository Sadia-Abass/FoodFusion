using FoodFusion.Server.Configurations;
using FoodFusion.Server.Data;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace FoodFusion.Server.Services.Impelementation
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SymmetricSecurityKey _secretKey;
        private readonly string? _validIssuer;
        private readonly string? _validAudience;
        private readonly double _expires;


        public TokenService(IConfiguration configuration, ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager) 
        { 
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));

            var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>();
            if (jwtSettings == null || string.IsNullOrEmpty(jwtSettings.Key))
            {
                throw new InvalidOperationException("JWT secret key is not configured.");
            }

            _secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));
            _validIssuer = jwtSettings.Issuer;
            _validAudience = jwtSettings.Audience;
            _expires = jwtSettings.MinutesToExpiration;
        }

        public async Task<string> GenerateAccessTokenAsync(ApplicationUser applicationUser)
        {
            var signingCredentials = new SigningCredentials(_secretKey, SecurityAlgorithms.HmacSha256);
            var claims = await GetClaimsAsync(applicationUser);
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        public string GenerateRefreshToken()
        {
            var randomBytes = new byte[64];
            using var randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(randomBytes);
            return Convert.ToBase64String(randomBytes);
        }

        public ClaimsPrincipal GetPrincipalFromExpiryToken(string token)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings.Key;

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = _validIssuer,
                ValidAudience = _validAudience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ValidateLifetime = false // Don't validate expiry for refresh
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principle = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);

            if(securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principle;
        }

        public async Task<bool> ValidateRefreshTokenAsync(string refreshToken, string userId)
        {
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);

            return user != null && user.RefreshToken == refreshToken && user.RefreshTokenExpiry > DateTime.UtcNow;
        }

        public async Task RevokeRefreshTokenAsync(string userId)
        {
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user != null)
            {
                user.RefreshToken = null;
                user.RefreshTokenExpiry = DateTime.UtcNow;
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task RevokeAllRefreshTokenAsync(string userId)
        {
            var user =await _applicationDbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user != null) 
            {
                user.RefreshToken = null;
                user.RefreshTokenExpiry = DateTime.UtcNow;
                // Remove all user tokens from Identity
                await _userManager.RemoveAuthenticationTokenAsync(user, "RefreshTokenProvider", "RefreshToken");
                await _applicationDbContext.SaveChangesAsync();
            }
        }


        private async Task<List<Claim>> GetClaimsAsync(ApplicationUser applicationUser)
        {
            // Get user roles and claims
            var roles = await _userManager.GetRolesAsync(applicationUser);
            var userClaims = await _userManager.GetClaimsAsync(applicationUser);
            

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, applicationUser.Id.ToString()),
                new Claim(ClaimTypes.Name, applicationUser.UserName ?? string.Empty),
                new Claim(ClaimTypes.Email, applicationUser?.Email ?? string.Empty),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
            };

            // Add role claims
            foreach(var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
                //roles.Select(role => new Claim(ClaimTypes.Role, role))
            }

            // Add custom claims
            claims.AddRange(userClaims);

            if (!string.IsNullOrEmpty(applicationUser.FirstName))
            {
                claims.Add(new Claim("FirstName", applicationUser.FirstName));
            }

            if (!string.IsNullOrEmpty(applicationUser.LastName))
            {
                claims.Add(new Claim("LastName", applicationUser.LastName));
            }

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            return new JwtSecurityToken(
                issuer: _validIssuer,
                audience: _validAudience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_expires),
                signingCredentials: signingCredentials
                );
        }
    }
}
