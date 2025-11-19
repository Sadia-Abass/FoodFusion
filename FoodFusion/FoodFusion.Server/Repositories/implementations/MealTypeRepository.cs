using FoodFusion.Server.Data;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MealTypeDTOs;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Repositories.implementations
{
    public class MealTypeRepository : IMealTypeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public MealTypeRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }
        public async Task<ApiResponse<MealTypeResponseDTO>> CreateMealTypeAsync(CreateMealTypeDTO createMealTypeDTO)
        {
            try
            {
                if(await _applicationDbContext.MealTypes.AnyAsync(m => m.Name.ToLower() == createMealTypeDTO.Name.ToLower()))
                {
                    return new ApiResponse<MealTypeResponseDTO>(400, "MealType name already exists.");
                }

                var mealType = new MealType
                {
                    Name = createMealTypeDTO.Name,
                    Description = createMealTypeDTO.Description,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                };

                _applicationDbContext.MealTypes.Add(mealType);
                await _applicationDbContext.SaveChangesAsync();

                var mealTypeResponse = new MealTypeResponseDTO
                {
                    MealTypeId = mealType.MealTypeId,
                    Name = mealType.Name,
                    Description = mealType.Description,
                    IsDeleted = mealType.IsDeleted
                };

                return new ApiResponse<MealTypeResponseDTO>(200, mealTypeResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<MealTypeResponseDTO>(500, $"n unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> DeleteMealTypeAsync(long id)
        {
            try
            {
                var mealType = await _applicationDbContext.MealTypes
                    .Include(m => m.MenuItems)
                    .FirstOrDefaultAsync(m => m.MealTypeId == id);

                if(mealType == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "MealType not found.");
                }

                mealType.IsDeleted = true;
                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"MealType with Id {id} deleted successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<List<MealTypeResponseDTO>>> GetAllMealTypeAsync()
        {
            try
            {
                var mealTypes = await _applicationDbContext.MealTypes
                    .AsNoTracking()
                    .ToListAsync();

                var mealTypeList = mealTypes.Select(m => new MealTypeResponseDTO
                {
                    MealTypeId = m.MealTypeId,
                    Name = m.Name,
                    Description = m.Description,
                    IsDeleted = m.IsDeleted,
                }).ToList();

                return new ApiResponse<List<MealTypeResponseDTO>>(200, mealTypeList);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<MealTypeResponseDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<MealTypeResponseDTO>> GetMealTypeByIdAsync(long id)
        {
            try
            {
                var mealType = await _applicationDbContext.MealTypes.AsNoTracking().FirstOrDefaultAsync(c => c.MealTypeId == id);
                if (mealType == null) 
                {
                    return new ApiResponse<MealTypeResponseDTO>(404, "MealType not found");
                }

                var mealTypeResponse = new MealTypeResponseDTO
                {
                    MealTypeId = mealType.MealTypeId,
                    Name = mealType.Name,
                    Description = mealType.Description,
                    IsDeleted = mealType.IsDeleted
                };

                return new ApiResponse<MealTypeResponseDTO>(200, mealTypeResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<MealTypeResponseDTO>(500, $"n unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> UpadteMealTypeAsync(UpdateMealTypeDTO updateMealTypeDTO)
        {
            try
            {
                var mealType = await _applicationDbContext.MealTypes.FindAsync(updateMealTypeDTO.MealTypeId);
                if(mealType == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "MealType not found.");
                }

                if(await _applicationDbContext.MealTypes.AnyAsync(m => m.Name.ToLower() == updateMealTypeDTO.Name.ToLower() && m.MealTypeId == updateMealTypeDTO.MealTypeId))
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, "MealType name already exists.");
                }

                mealType.Name = updateMealTypeDTO.Name;
                mealType.Description = updateMealTypeDTO.Description;
                mealType.ModifiedDate = DateTime.UtcNow;

                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"MealType with Id {updateMealTypeDTO.MealTypeId} updated successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"n unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }
    }
}
