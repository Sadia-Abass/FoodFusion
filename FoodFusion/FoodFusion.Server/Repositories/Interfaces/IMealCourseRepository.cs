using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MealCourseDTOs;

namespace FoodFusion.Server.Repositories.Interfaces
{
    public interface IMealCourseRepository
    {
        Task<ApiResponse<MealCourseResponseDTO>> GetAllMealCourseAsync();
        Task<ApiResponse<MealCourseResponseDTO>> GetMealCourseByIdAsync(long id);
        Task<ApiResponse<MealCourseResponseDTO>> CreateMealCourseAsync(CreateMealCourseDTO createMealCourseDTO);
        Task<ApiResponse<ConfirmationResponseDTO>> DeleteMealCourseAsync(long id);
        Task<ApiResponse<ConfirmationResponseDTO>> UpdateMealCourseAsync(UpdateMealCourseDTO updateMealCourseDTO);
    }
}
