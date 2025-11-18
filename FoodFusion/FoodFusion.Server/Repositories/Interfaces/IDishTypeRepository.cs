using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.DishTypeDTOs;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface IDishTypeRepository
    {
        Task<ApiResponse<DishTypeResponseDTO>> GetAllDishTypeAsync();
        Task<ApiResponse<DishTypeResponseDTO>> GetDishTypeByIDAsync(long id);
        Task<ApiResponse<DishTypeResponseDTO>> CreateDishTypeAsync(CreateDishTypeDTO createDishTypeDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateDishTypeAsync(UpdateDishTypeDTO updateDishTypeDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteDishTypeAsync(long id);
    }
}
