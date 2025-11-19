using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.CuisineDTOs;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface ICuisineRepository
    {
        Task<ApiResponse<List<CuisineResponseDTO>>> GetAllCuisineAsync();
        Task<ApiResponse<CuisineResponseDTO>> GetCuisineByIdAsync(long id);
        Task<ApiResponse<CuisineResponseDTO>> CreateCuisineAsync(CreateCuisineDTO createCuisineDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateCuisineAsync(UpdateCuisineDTO updateCuisineDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteCuisineByIdAsync(long id);
    }
}
