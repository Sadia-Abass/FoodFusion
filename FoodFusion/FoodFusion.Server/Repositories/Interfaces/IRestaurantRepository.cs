using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.RestaurantDTO;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<ApiResponse<List<RestaurantResponseDTO>>> GetAllRestarantAsync();
        Task<ApiResponse<RestaurantResponseDTO>> GetRestaurantByIdAsync(long id);
        Task<ApiResponse<RestaurantResponseDTO>> CreateRestaurantAsync(CreateRestaurantDTO createRestaurantDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateRestaurantAsync(UpdateRestaurantDTO updateRestaurantDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteRestaurantAsync(long id);
    }
}
