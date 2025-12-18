using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MenuItemDTOs;
using FoodFusion.Server.Repositories.implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly MenuItemRepository _menuItemRepository;

        public MenuItemController(MenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        [HttpGet("GetAllMenuItem")]
        public async Task<ActionResult<ApiResponse<List<MenuItemResponseDTO>>>> GetAllMenuItem()
        {
            var response = await _menuItemRepository.GetAllMenuItemAsync();
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetMenuItemById/{id}")]
        public async Task<ActionResult<ApiResponse<MenuItemResponseDTO>>> GetMenuItemById(long id)
        {
            var response = await _menuItemRepository.GetMenuItemByIdAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetMenuItemByCuisine/{id}")]
        public async Task<ActionResult<ApiResponse<List<MenuItemResponseDTO>>>> GetMenuItemByCuisine(long id)
        {
            var response = await _menuItemRepository.GetMenuItemByCuisineAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetMenuItemByMealCourse/{id}")]
        public async Task<ActionResult<ApiResponse<List<MenuItemResponseDTO>>>> GetMenuItemByMealCourse(long id)
        {
            var response = await _menuItemRepository.GetMenuItemByMealCourseAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetMenuItemByMealType/{id}")]
        public async Task<ActionResult<ApiResponse<List<MenuItemResponseDTO>>>> GetMenuItemByMealType(long id)
        {
            var response = await _menuItemRepository.GetMenuItemByMealTypeAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetMenuItemByDishType/{id}")]
        public async Task<ActionResult<ApiResponse<List<MenuItemResponseDTO>>>> GetMenuItemByDishType(long id)
        {
            var response = await _menuItemRepository.GetMenuItemByDishTypeAsync(id);
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPost("CreateMenuItem")]
        public async Task<ActionResult<ApiResponse<MenuItemResponseDTO>>> CreatemenuItem([FromBody] CreateMenuItemDTO createMenuItemDTO)
        {
            var response = await _menuItemRepository.CreateMenuItemAsync(createMenuItemDTO);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPut("UpdateMenuItem")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateMenuItem([FromBody] UpdateMenuItemDTO updateMenuItemDTO)
        {
            var response = await _menuItemRepository.UpdateMenuItemAsync(updateMenuItemDTO);
            if( response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpDelete("DeleteMenuItem")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteMenuItem(long id)
        {
            var response = await _menuItemRepository.DeleteMenuItemAsync(id);
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }
    }
}
