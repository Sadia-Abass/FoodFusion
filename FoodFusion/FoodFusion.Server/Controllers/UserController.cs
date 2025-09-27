using FoodFusion.Server.DTOs.Auth;
using FoodFusion.Server.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationUser> _roleManager;

        public UserController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationUser> roleManager) 
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
        }

        [HttpGet("get-user")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<ApplicationUserDTO>>> GetUsers()
        {
            var users = _userManager.Users.ToList();
            var userDTOs = new List<ApplicationUserDTO>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userDTOs.Add(new ApplicationUserDTO
                {
                    Id = user.Id,
                    Username = user.UserName ?? "",
                    Email = user.Email ?? "",
                    EmailConfirmed = user.EmailConfirmed,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber ?? "",
                    CreatedDate = user.CreatedDate,
                    Roles = roles.ToList()
                });
            }

            return Ok(userDTOs);
        }

        [HttpPost("{userId}/roles/{roleName}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddUserToRole([FromHeader] string userId, [FromBody] string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            if (!await _roleManager.RoleExistsAsync(roleName)) 
            {
                return BadRequest(new { message = "Role does not exist" });
            }

            var response = await _userManager.AddToRoleAsync(user, roleName);
            if (!response.Succeeded) 
            {
                return BadRequest(new { message = "Failed to add user to role", errors = response.Errors });
            }

            return Ok(new {message = $"ser added to {roleName} role successfully" });
        }

        [HttpDelete("{userId}/roles/{roleName}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveUserFromRole([FromHeader]string userId, [FromBody]string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) 
            {
                return NotFound(new { message = "User not found"});
            }

            var response = await _userManager.RemoveFromRoleAsync(user, roleName);
            if (!response.Succeeded)
            {
                return BadRequest(new { message = "Failed to remove user from role", errors = response.Errors });
            }

            return Ok(new {message = $"User removed from {roleName} role successfully" });
        }
    }
}
