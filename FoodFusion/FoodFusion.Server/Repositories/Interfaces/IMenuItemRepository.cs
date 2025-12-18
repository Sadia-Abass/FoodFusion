using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MenuItemDTOs;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface IMenuItemRepository
    {
        Task<ApiResponse<PaginationResult<MenuItemListDTO>>> GetAllMenuItemAsync();
        Task<ApiResponse<MenuItemResponseDTO>> GetMenuItemByIdAsync(long id);
        Task<ApiResponse<MenuItemResponseDTO>> CreateMenuItemAsync(CreateMenuItemDTO createMenuItemDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateMenuItemAsync(UpdateMenuItemDTO updateMenuItemDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteMenuItemAsync(long id);
        Task<ApiResponse<List<MenuItemListDTO>>> GetMenuItemByCuisineAsync(long cuisineId);
        Task<ApiResponse<List<MenuItemListDTO>>> GetMenuItemByMealTypeAsync(long mealTypeId);
        Task<ApiResponse<List<MenuItemListDTO>>> GetMenuItemByMealCourseAsync(long mealCourseId);
        Task<ApiResponse<List<MenuItemListDTO>>> GetMenuItemByDishTypeAsync(long dishTypeId);
    }
}
