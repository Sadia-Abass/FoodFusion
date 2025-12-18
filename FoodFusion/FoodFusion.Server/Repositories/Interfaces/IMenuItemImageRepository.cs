using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MenuItemImageDTOs;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface IMenuItemImageRepository
    {
        Task<ApiResponse<List<MenuItemImageResponseDTO>>> GetMenuItemImageAsync();
        Task<ApiResponse<MenuItemImageResponseDTO>> GetMenuItemImageByIdAsnc(long id);
        Task<ApiResponse<MenuItemImageResponseDTO>> CreateMenuItemImageAsync(CreateMenuItemImageDTO createMenuItemImageDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateMenuItemImageAsync(UpdateMenuItemImageDTO updateMenuItemImageDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteMenuItemImageAsync(long id);
    }
}
