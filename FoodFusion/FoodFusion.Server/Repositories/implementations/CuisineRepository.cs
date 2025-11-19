using FoodFusion.Server.Data;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.CuisineDTOs;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Repositories.implementations
{
    public class CuisineRepository : ICuisineRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CuisineRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<ApiResponse<List<CuisineResponseDTO>>> GetAllCuisineAsync()
        {
            try
            {
                var cuisines = await _applicationDbContext.Cuisines.AsNoTracking().ToListAsync();
                var cuisineList = cuisines.Select(c => new CuisineResponseDTO
                {
                    CuisineID = c.CuisineID,
                    Name = c.Name,
                    Description = c.Description,
                    Region = c.Region,
                    IsDeleted = c.IsDeleted
                }).ToList();

                return new ApiResponse<List<CuisineResponseDTO>>(200, cuisineList);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<CuisineResponseDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<CuisineResponseDTO>> GetCuisineByIdAsync(long id)
        {
            try
            {
                var cuisine = await _applicationDbContext.Cuisines.AsNoTracking().FirstOrDefaultAsync(c => c.CuisineID == id);
                if(cuisine == null)
                {
                    return new ApiResponse<CuisineResponseDTO>(404, "Cuisine not found.");
                }

                var cuisineResponse = new CuisineResponseDTO
                {
                    CuisineID = cuisine.CuisineID,
                    Name = cuisine.Name,
                    Description = cuisine.Description,
                    Region = cuisine.Region,
                    IsDeleted = cuisine.IsDeleted
                };

                return new ApiResponse<CuisineResponseDTO>(200, cuisineResponse);

            }
            catch (Exception ex) 
            {
                return new ApiResponse<CuisineResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<CuisineResponseDTO>> CreateCuisineAsync(CreateCuisineDTO createCuisineDTO)
        {
            try
            {
                if (await _applicationDbContext.Cuisines.AnyAsync(c => c.Name.ToLower() == createCuisineDTO.Name.ToLower()))
                {
                    return new ApiResponse<CuisineResponseDTO>(400, "Cuisine name already exists.");
                }

                var cuisine = new Cuisine
                {
                    Name = createCuisineDTO.Name,
                    Description = createCuisineDTO.Description,
                    Region = createCuisineDTO.Region,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                };

                _applicationDbContext.Cuisines.Add(cuisine);
                await _applicationDbContext.SaveChangesAsync();

                var cuisineResponse = new CuisineResponseDTO
                {
                    CuisineID = cuisine.CuisineID,
                    Name = cuisine.Name,
                    Description = cuisine.Description,
                    Region = cuisine.Region,
                    IsDeleted = cuisine.IsDeleted
                };

                return new ApiResponse<CuisineResponseDTO>(200, cuisineResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<CuisineResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> UpdateCuisineAsync(UpdateCuisineDTO updateCuisineDTO)
        {
            try
            {
                var cuisine = await _applicationDbContext.Cuisines.FindAsync(updateCuisineDTO.CuisineID);
                if(cuisine == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "Cuisine not found.");
                }

                if(await _applicationDbContext.Cuisines.AnyAsync(c => c.Name.ToLower() == updateCuisineDTO.Name.ToLower() && c.CuisineID == updateCuisineDTO.CuisineID))
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, "cuisine name already exists.");
                }

                cuisine.Name = updateCuisineDTO.Name;
                cuisine.Description = updateCuisineDTO.Description;
                cuisine.Region = updateCuisineDTO.Region;
                cuisine.UpdatedDate = DateTime.UtcNow;

                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"Cuisine with Id {updateCuisineDTO.CuisineID} updated successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);

            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> DeleteCuisineByIdAsync(long id)
        {
            try
            {
                var cuisine = await _applicationDbContext.Cuisines
                    .Include(c => c.MenuItems)
                    .Include(c => c.Restaurants)
                    .FirstOrDefaultAsync(c => c.CuisineID == id); 

                if(cuisine == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "Cuisine not found.");
                }

                cuisine.IsDeleted = true;
                await _applicationDbContext.SaveChangesAsync();

                var ConfirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"Cuisine with Id {id} deleted successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, ConfirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }
    }
}
