using FoodFusion.Server.Configurations;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.Auth;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;


namespace FoodFusion.Server.Services.Impelementation
{  
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly SymmetricSecurityKey _secretKey;
        private readonly double _expires;
        private readonly int _expiresInDays;

        public AuthenticationService(IConfiguration configuration, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ITokenService tokenService)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
            _tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));

            var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>();
            if (jwtSettings == null || string.IsNullOrEmpty(jwtSettings.Key))
            {
                throw new InvalidOperationException("JWT secret key is not configured.");
            }

            _secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));
            _expires = jwtSettings.MinutesToExpiration;
            _expiresInDays = jwtSettings.RefreshTokenExpireDays;
        }

        public async Task<ApiResponse<TokenResponseDTO>> RegisterAsync(RegisterDto registerDto)
        {
            try
            {
                var existingUser = await _userManager.FindByEmailAsync(registerDto.Email!);
                if (existingUser != null) 
                {
                    return new ApiResponse<TokenResponseDTO>(400, "User with this email already exists");
                }

                var newUser = new ApplicationUser
                {
                    UserName = registerDto.Username,
                    Email = registerDto.Email,
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    PhoneNumber = registerDto.PhoneNumber,
                    CreatedDate = DateTime.UtcNow
                };

                var result = await _userManager.CreateAsync(newUser, registerDto.Password!);
                if (!result.Succeeded)
                {
                    return new ApiResponse<TokenResponseDTO>(400, result.Errors.Select(e => e.Description).ToList();
                }

                // Add customer to default role
                await _userManager.AddToRoleAsync(newUser, "Customer");

                var tokenResponse = await GenerateTokenResponseAsync(newUser);
                return new ApiResponse<TokenResponseDTO>(200, tokenResponse);

            }
            catch (Exception ex) 
            {
                return new ApiResponse<TokenResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }


        public async Task<ApiResponse<TokenResponseDTO>> LoginAsync(LoginDto loginDto)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                if (user == null)
                {
                    return new ApiResponse<TokenResponseDTO>(400, "Invalid email or password");
                }

                var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, lockoutOnFailure: true);
                if (!result.Succeeded)
                {
                    var error = result.IsLockedOut ? "Account is locked out" : result.IsNotAllowed ? "Account is not allowed to sign in" : "Invalid email or password";
                    return new ApiResponse<TokenResponseDTO>(400, error);
                }

                var tokenResponse = await GenerateTokenResponseAsync(user);
                return new ApiResponse<TokenResponseDTO>(200, tokenResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<TokenResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }        
        }


        public async Task<ApiResponse<TokenResponseDTO>> RefreshTokenAsync(RefreshTokenDTO refreshTokenDTO)
        {
            try
            {
                var principal = _tokenService.GetPrincipalFromExpiryToken(refreshTokenDTO.AccessToken);
                var userId = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0";

                if (userId == "0" || !await _tokenService.ValidateRefreshTokenAsync(refreshTokenDTO.RefreshToken, userId))
                {
                    return new ApiResponse<TokenResponseDTO>(400, "Invalid refresh token");
                }

                var user = await _userManager.FindByIdAsync(userId);
                if (user == null) 
                {
                    return new ApiResponse<TokenResponseDTO>(400, "User not found");
                }

                var tokenResponse = await GenerateTokenResponseAsync(user);
                return new ApiResponse<TokenResponseDTO>(200, tokenResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<TokenResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }


        public async Task<bool> LogoutAsync(string userId)
        {
            await _tokenService.RevokeRefreshTokenAsync(userId);
            return true;
        }


        public async Task<ApplicationUserDTO?> GetUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) 
            {
                return null;
            }

            var roles = await _userManager.GetRolesAsync(user);

            return new ApplicationUserDTO
            {
                Id = user.Id,
                Username = user.UserName ?? "",
                Email =user.Email ?? "",
                EmailConfirmed = user.EmailConfirmed,
                FirstName = user.FirstName,
                LastName = user.LastName,
                CreatedDate = user.CreatedDate,
                Roles = roles.ToList()
            };
        }


        public async Task<ApiResponse<ConfirmationResponseDTO>> ChangePasswordAsync(string userId, ChangePasswordDTO changePasswordDTO)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user == null) 
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, "User not found");
                }

                var result = await _userManager.ChangePasswordAsync(user, changePasswordDTO.CurrentPassword, changePasswordDTO.NewPassword);
                if (!result.Succeeded)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, result.Errors.Select(e => e.Description).ToList());
                }

                return new ApiResponse<ConfirmationResponseDTO>(200, "Password change was successful");
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }


        public async Task<ApiResponse<ConfirmationResponseDTO>> ForgotPasswordAsync(ForgotPasswordDTO forgotPasswordDTO)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(forgotPasswordDTO.Email);
                if (user == null)
                {
                    // Don't reveal that the user does not exist
                    return new ApiResponse<ConfirmationResponseDTO>(200, "");
                }

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                // Here you would typically send an email with the reset token
                // For demo purposes, we'll just log it or return it
                // In production, integrate with email service like SendGrid, etc.

                return new ApiResponse<ConfirmationResponseDTO>(200, "");
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }


        public async Task<ApiResponse<ConfirmationResponseDTO>> ResetPasswordAsync(ResetPasswordDTO resetPasswordDTO)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(resetPasswordDTO.Email);
                if (user == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, "Invald request");
                }

                var result = await _userManager.ResetPasswordAsync(user, resetPasswordDTO.Token, resetPasswordDTO.NewPassword);

                if (!result.Succeeded)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, result.Errors.Select(e => e.Description).ToList());
                }

                return new ApiResponse<ConfirmationResponseDTO>(200, "Pass reset is successful");
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
         
        }

        private async Task<TokenResponseDTO> GenerateTokenResponseAsync(ApplicationUser applicationUser)
        {
            var accessToken = await _tokenService.GenerateAccessTokenAsync(applicationUser);
            var refreshToken = _tokenService.GenerateRefreshToken();

            var refreshTokenExpiry = DateTime.UtcNow.AddDays(_expiresInDays);

            applicationUser.RefreshToken = refreshToken;
            applicationUser.RefreshTokenExpiry = refreshTokenExpiry;
            await _userManager.UpdateAsync(applicationUser);

            var userDto = await GetUserAsync(applicationUser.Id);

            return new TokenResponseDTO
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                TokenExpiry = DateTime.UtcNow.AddMinutes(_expires),
                User = userDto!
            };
        }
    }
}
