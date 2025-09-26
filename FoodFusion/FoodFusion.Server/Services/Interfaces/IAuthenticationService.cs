using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.Auth;

namespace FoodFusion.Server.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ApiResponse<TokenResponseDTO>> RegisterAsync(RegisterDto registerDto);
        Task<ApiResponse<TokenResponseDTO>> LoginAsync(LoginDto loginDto);
        Task<ApiResponse<TokenResponseDTO>> RefreshTokenAsync(RefreshTokenDTO refreshTokenDTO);
        Task<bool> LogoutAsync(string userId);
        Task<ApplicationUserDTO?> GetUserAsync(string userId);
        Task<ApiResponse<ConfirmationResponseDTO>> ChangePasswordAsync(string userId, ChangePasswordDTO changePasswordDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> ForgotPasswordAsync(ForgotPasswordDTO forgotPasswordDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> ResetPasswordAsync(ResetPasswordDTO resetPasswordDTO);
    }
}
