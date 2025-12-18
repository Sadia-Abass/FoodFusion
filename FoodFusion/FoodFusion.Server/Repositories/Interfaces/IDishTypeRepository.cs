using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.DishTypeDTOs;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface IDishTypeRepository
    {
        Task<ApiResponse<List<DishTypeResponseDTO>>> GetAllDishTypeAsync();
        Task<ApiResponse<DishTypeResponseDTO>> GetDishTypeByIDAsync(long id);
        Task<ApiResponse<DishTypeResponseDTO>> CreateDishTypeAsync(CreateDishTypeDTO createDishTypeDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateDishTypeAsync(UpdateDishTypeDTO updateDishTypeDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteDishTypeAsync(long id);
        Task<bool> ExistsAsync(long id);
    }
}
