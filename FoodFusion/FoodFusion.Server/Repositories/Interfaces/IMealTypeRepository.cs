using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MealTypeDTOs;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface IMealTypeRepository
    {
        Task<ApiResponse<MealTypeResponseDTO>> GetAllMealTypeAsync();
        Task<ApiResponse<MealTypeResponseDTO>> GetMealTypeByIdAsync(long id);
        Task<ApiResponse<MealTypeResponseDTO>> CreateMealTypeAsync(CreateMealTypeDTO createMealTypeDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteMealTypeAsync(long id);
        Task<ApiResponse<ConfirmationResponseDTO>> UpadteMealTypeAsync(UpdateMealTypeDTO updateMealTypeDTO);
    }
}
