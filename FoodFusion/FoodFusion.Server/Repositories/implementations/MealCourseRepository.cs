using FoodFusion.Server.Data;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MealCourseDTOs;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Repositories.implementations
{
    public class MealCourseRepository : IMealCourseRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public MealCourseRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<ApiResponse<MealCourseResponseDTO>> CreateMealCourseAsync(CreateMealCourseDTO createMealCourseDTO)
        {
            try
            {
                if(await _applicationDbContext.MealCourses.AnyAsync(mc => mc.Name.ToLower() == createMealCourseDTO.Name.ToLower()))
                {
                    return new ApiResponse<MealCourseResponseDTO>(400, "MealCourse name already exists.");
                }

                var mealCourse = new MealCourse
                {
                    Name = createMealCourseDTO.Name,
                    Description = createMealCourseDTO.Description,
                    DisplayOrder = createMealCourseDTO.DisplayOrder,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                };

                _applicationDbContext.MealCourses.Add(mealCourse);
                await _applicationDbContext.SaveChangesAsync();

                var mealCourseResponse = new MealCourseResponseDTO
                {
                    MealCourseId = mealCourse.MealCourseId,
                    Name = mealCourse.Name,
                    Description = createMealCourseDTO.Description,
                    DisplayOrder = createMealCourseDTO.DisplayOrder,
                    IsDeleted = mealCourse.IsDeleted
                };

                return new ApiResponse<MealCourseResponseDTO>(200, mealCourseResponse);
            }
            catch (Exception ex) 
            { 
                return new ApiResponse<MealCourseResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> DeleteMealCourseAsync(long id)
        {
            try
            {
                var mealCourse = await _applicationDbContext.MealCourses.Include(mc => mc.MenuItems).FirstOrDefaultAsync();
                if (mealCourse == null) 
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "MealCourse not found");
                }

                mealCourse.IsDeleted = true;
                await _applicationDbContext.SaveChangesAsync();

                var mealCourseResponse = new ConfirmationResponseDTO
                {
                    Message = $"MealCourse with Id {id} deleted successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, mealCourseResponse);
            }
            catch (Exception ex) 
            
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<List<MealCourseResponseDTO>>> GetAllMealCourseAsync()
        {
            try
            {
                var mealCourse = await _applicationDbContext.MealCourses
                    .AsNoTracking()
                    .ToListAsync();

                var mealCourseList = mealCourse.Select(mc => new MealCourseResponseDTO
                {
                    MealCourseId = mc.MealCourseId,
                    Name = mc.Name,
                    Description = mc.Description,
                    DisplayOrder = mc.DisplayOrder,
                    IsDeleted = mc.IsDeleted,
                }).ToList();

                return new ApiResponse<List<MealCourseResponseDTO>>(200, mealCourseList);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<MealCourseResponseDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<MealCourseResponseDTO>> GetMealCourseByIdAsync(long id)
        {
            try
            {
                var mealCourse = await _applicationDbContext.MealCourses.AsNoTracking().FirstOrDefaultAsync(mc => mc.MealCourseId == id);
                if(mealCourse == null)
                {
                    return new ApiResponse<MealCourseResponseDTO>(404, "MealCourse not found");
                }

                var mealCourseResponse = new MealCourseResponseDTO
                {
                    MealCourseId = mealCourse.MealCourseId,
                    Name = mealCourse.Name,
                    Description = mealCourse.Description,
                    DisplayOrder = mealCourse.DisplayOrder,
                    IsDeleted = mealCourse.IsDeleted
                };

                return new ApiResponse<MealCourseResponseDTO>(200, mealCourseResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<MealCourseResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> UpdateMealCourseAsync(UpdateMealCourseDTO updateMealCourseDTO)
        {
            try
            {
                var mealCourse = await _applicationDbContext.MealCourses.FindAsync(updateMealCourseDTO.MealCourseId);
                if(mealCourse == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "MealCourse not found");
                }

                if(await _applicationDbContext.MealCourses.AnyAsync(mc => mc.Name.ToLower() == updateMealCourseDTO.Name.ToLower() && mc.MealCourseId != updateMealCourseDTO.MealCourseId))
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, "Another MealCourse with the same already exists.");
                }

                mealCourse.Name = updateMealCourseDTO.Name;
                mealCourse.DisplayOrder = updateMealCourseDTO.DisplayOrder;
                mealCourse.DisplayOrder = updateMealCourseDTO.DisplayOrder;
                mealCourse.LastModifiedDate = DateTime.UtcNow;
                await _applicationDbContext.SaveChangesAsync();

                var confirmationResponse = new ConfirmationResponseDTO
                {
                    Message = $"MealCourse with Id {updateMealCourseDTO.MealCourseId} updated successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }
    }
}
