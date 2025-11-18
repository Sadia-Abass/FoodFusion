using FoodFusion.Server.DTOs.Auth;
using FoodFusion.Server.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
        }

        [HttpPost("register")]
        public async Task<ActionResult<TokenResponseDTO>> Register([FromBody]RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _authenticationService.RegisterAsync(registerDto);
            if (!response.IsSuccess)
            {
                return BadRequest(new { message = "Registration failed" });
            }

            return Ok(response);
        }



        [HttpPost("login")]
        public async Task<ActionResult<TokenResponseDTO>> Login([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _authenticationService.LoginAsync(loginDto);
            if (!response.IsSuccess)
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }

            return Ok(response);
        }



        [HttpPost("refresh")]
        public async Task<ActionResult<TokenResponseDTO>> RefreshToken([FromBody]RefreshTokenDTO refreshTokenDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _authenticationService.RefreshTokenAsync(refreshTokenDTO);
            if (!response.IsSuccess)
            {
                return BadRequest(/*new { return Unauthorized(new { message = "Invalid email or password."}*/); 
            }

            return Ok(response);
        }


        [HttpGet("logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            var userId = GetCurrentUserId();
            await _authenticationService.LogoutAsync(userId);

            return Ok(new {message = "Logged out successfully" });
        }

        [HttpGet("current-user")]
        [Authorize]
        public async Task<ActionResult<ApplicationUserDTO>> GetCurrentUser()
        {
            var userId = GetCurrentUserId();
            var user = await _authenticationService.GetUserAsync(userId);

            if (user != null)
            {
                return NotFound(new { message = "User not found" });
            }

            return Ok(user);
        }

        [HttpPost("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO changePasswordDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = GetCurrentUserId();
            var response = await _authenticationService.ChangePasswordAsync(userId, changePasswordDTO);
            if (!response.IsSuccess)
            {
                return BadRequest(new {message = "Password change failed" });
            }

            return Ok(response);
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody]  ForgotPasswordDTO orgotPasswordDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _authenticationService.ForgotPasswordAsync(orgotPasswordDTO);
            if (!response.IsSuccess)
            {
                return BadRequest(new {message = "Failed to process request" });
            }

            return Ok(new {message = "If the email exists, a password reset link has been sent" });
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDTO resetPasswordDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _authenticationService.ResetPasswordAsync(resetPasswordDTO);
            if (!response.IsSuccess)
            {
                return BadRequest(new { message = "Password reset failed" });
            }

            return Ok(new {message = "Password reset successfully" });
        }

        private string GetCurrentUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
