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
        Task<ApiResponse<MenuItemListDTO>> GetMenuItemByCuisineAsync(long cuisineId);
        Task<ApiResponse<MenuItemListDTO>> GetMenuItemByMealTypeAsync(long mealTypeId);
        Task<ApiResponse<MenuItemListDTO>> GetMenuItemByMealCourseAsync(long mealCourseId);
        Task<ApiResponse<MenuItemListDTO>> GetMenuItemByDishTypeAsync(long dishTypeId);
    }
}
