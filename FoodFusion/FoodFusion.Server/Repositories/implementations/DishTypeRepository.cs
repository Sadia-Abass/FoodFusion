using FoodFusion.Server.Data;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.DishTypeDTOs;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Repositories.implementations
{
    public class DishTypeRepository : IDishTypeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DishTypeRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<ApiResponse<DishTypeResponseDTO>> CreateDishTypeAsync(CreateDishTypeDTO createDishTypeDTO)
        {
            try
            {
                if(await _applicationDbContext.DishTypes.AnyAsync(dt => dt.Name.ToLower() == createDishTypeDTO.Name.ToLower()))
                {
                    return new ApiResponse<DishTypeResponseDTO>(400, "DishType name already exists.");
                }

                var dishType = new DishType
                {
                    Name = createDishTypeDTO.Name,
                    Description = createDishTypeDTO.Description,
                    IsDeleted = false
                };

                _applicationDbContext.DishTypes.Add(dishType);
                await _applicationDbContext.SaveChangesAsync();

                var dishTypeResponse = new DishTypeResponseDTO
                {
                    DishTypeId = dishType.DishTypeId,
                    Name = dishType.Name,
                    Description = dishType.Description,
                    IsDeleted = dishType.IsDeleted
                };

                return new ApiResponse<DishTypeResponseDTO>(200, dishTypeResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<DishTypeResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> DeleteDishTypeAsync(long id)
        {
            try
            {
                var dishType = await _applicationDbContext.DishTypes
                    .Include(dt => dt.MenuItemDishTypes)
                    .FirstOrDefaultAsync(dt => dt.DishTypeId == id);

                if(dishType == null) 
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "DishType not found.");
                }

                dishType.IsDeleted = true;
                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"DishTye with Id {id} deleted successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<List<DishTypeResponseDTO>>> GetAllDishTypeAsync()
        {
            try
            {
                var dishType = await _applicationDbContext.DishTypes
                    .AsNoTracking()
                    .ToListAsync();

                var dishTypeList = dishType.Select(dt => new DishTypeResponseDTO
                {
                    DishTypeId = dt.DishTypeId,
                    Name = dt.Name,
                    Description = dt.Description,
                    IsDeleted = dt.IsDeleted,
                }).ToList();

                return new ApiResponse<List<DishTypeResponseDTO>>(200, dishTypeList);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<DishTypeResponseDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<DishTypeResponseDTO>> GetDishTypeByIDAsync(long id)
        {
            try
            {
                var dishType = await _applicationDbContext.DishTypes
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if(dishType == null)
                {
                    return new ApiResponse<DishTypeResponseDTO>(404, "DishType not found." );
                }

                var dishTypeResponse = new DishTypeResponseDTO
                {
                    DishTypeId= dishType.DishTypeId,
                    Name = dishType.Name,
                    Description = dishType.Description,
                    IsDeleted = dishType.IsDeleted
                };

                return new ApiResponse<DishTypeResponseDTO>(200, dishTypeResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse<DishTypeResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}"); 
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> UpdateDishTypeAsync(UpdateDishTypeDTO updateDishTypeDTO)
        {
            try
            {
                var dishType = await _applicationDbContext.DishTypes.FindAsync(updateDishTypeDTO.DishTypeId);
                if(dishType == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "DishType not found");
                }

                if(await _applicationDbContext.DishTypes.AnyAsync(dt => dt.Name.ToLower() == updateDishTypeDTO.Name.ToLower() && dt.DishTypeId != updateDishTypeDTO.DishTypeId))
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, "Another dishType with the same name already exists.");
                }

                dishType.Name = updateDishTypeDTO.Name;
                dishType.Description = updateDishTypeDTO.Description;
                dishType.CreatedDate = DateTime.UtcNow;

                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"DishType with Id {updateDishTypeDTO.DishTypeId} updated successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }
    }
}
