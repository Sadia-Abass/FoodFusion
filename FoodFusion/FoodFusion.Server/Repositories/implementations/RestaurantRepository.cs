using FoodFusion.Server.Data;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.RestaurantDTO;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Repositories.implementations
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RestaurantRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<ApiResponse<List<RestaurantResponseDTO>>> GetAllRestarantAsync()
        {
            try
            {
                var restaurants = await _applicationDbContext.Restaurants.AsNoTracking().ToListAsync();

                var listsOfRestaurants = restaurants.Select(r => new RestaurantResponseDTO
                {
                    RestaurantId = r.RestaurantId,
                    Name = r.Name,
                    AddressLineOne = r.AddressLineOne,
                    AddressLineTwo = r.AddressLineTwo,
                    City = r.City,
                    PostCode = r.PostCode,
                    PhoneNumber = r.PhoneNumber,
                    DaysOfWeek = r.DaysOfWeek,
                    OpeningTime = r.OpeningTime,
                    ClosingTime = r.ClosingTime,
                    NumbersOfTables = r.NumbersOfTables,
                    Logo = r.Logo
                }).ToList();

                return new ApiResponse<List<RestaurantResponseDTO>>(200, listsOfRestaurants);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<RestaurantResponseDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<RestaurantResponseDTO>> GetRestaurantByIdAsync(long id)
        {
            try
            {
                var restaurant = await _applicationDbContext.Restaurants.AsNoTracking().FirstOrDefaultAsync(r => r.RestaurantId == id);

                if (restaurant == null) 
                {
                    return new ApiResponse<RestaurantResponseDTO>(404, "Restaurant not found.");
                }

                var restraurantResponse = new RestaurantResponseDTO
                {
                    RestaurantId = restaurant.RestaurantId,
                    Name = restaurant.Name,
                    AddressLineOne = restaurant.AddressLineOne,
                    AddressLineTwo = restaurant.AddressLineTwo,
                    City = restaurant.City,
                    PostCode = restaurant.PostCode,
                    PhoneNumber = restaurant.PhoneNumber,
                    DaysOfWeek = restaurant.DaysOfWeek,
                    OpeningTime = restaurant.OpeningTime,
                    ClosingTime = restaurant.ClosingTime,
                    NumbersOfTables = restaurant.NumbersOfTables,
                    Logo = restaurant.Logo
                };

                return new ApiResponse<RestaurantResponseDTO>(200, restraurantResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<RestaurantResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<RestaurantResponseDTO>> CreateRestaurantAsync(CreateRestaurantDTO createRestaurantDTO)
        {
            try
            {
                if(await _applicationDbContext.Restaurants.AnyAsync(r => r.Name.ToLower() == createRestaurantDTO.Name.ToLower()))
                {
                    return new ApiResponse<RestaurantResponseDTO>(404, "Restaurant name already exists.");
                }

                var restaurant = new Restaurant
                {
                    Name = createRestaurantDTO.Name,
                    AddressLineOne = createRestaurantDTO.AddressLineOne,
                    AddressLineTwo = createRestaurantDTO.AddressLineTwo,
                    City = createRestaurantDTO.City,
                    PostCode = createRestaurantDTO.PostCode,
                    PhoneNumber = createRestaurantDTO.PhoneNumber,
                    DaysOfWeek  = createRestaurantDTO.DaysOfWeek,
                    OpeningTime = createRestaurantDTO.OpeningTime,
                    ClosingTime = createRestaurantDTO.ClosingTime,
                    NumbersOfTables = createRestaurantDTO.NumbersOfTables,
                    Logo = createRestaurantDTO.Logo,
                    CreatedDate = DateTime.UtcNow
                };

                await _applicationDbContext.Restaurants.AddAsync(restaurant);
                await _applicationDbContext.SaveChangesAsync();

                var restaurantResponse = new RestaurantResponseDTO
                {
                    RestaurantId = restaurant.RestaurantId,
                    Name = restaurant.Name,
                    AddressLineOne = restaurant.AddressLineOne,
                    AddressLineTwo = restaurant.AddressLineTwo,
                    City = restaurant.City,
                    PostCode = restaurant.PostCode,
                    PhoneNumber = restaurant.PhoneNumber,
                    DaysOfWeek = restaurant.DaysOfWeek,
                    OpeningTime = restaurant.OpeningTime,
                    ClosingTime = restaurant.ClosingTime,
                    NumbersOfTables = restaurant.NumbersOfTables,
                    Logo = restaurant.Logo,
                    IsDeleted = restaurant.IsDeleted
                };

                return new ApiResponse<RestaurantResponseDTO>(200, restaurantResponse);
            }
            catch (Exception ex)
            {
                return new ApiResponse<RestaurantResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> UpdateRestaurantAsync(UpdateRestaurantDTO updateRestaurantDTO)
        {
            try
            {
                var restaurant = await _applicationDbContext.Restaurants.FindAsync(updateRestaurantDTO.RestaurantId);
                if(restaurant == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "Restaurant not found");
                }

                if(await _applicationDbContext.Restaurants.AnyAsync(r => r.Name.ToLower() == updateRestaurantDTO.Name.ToLower() && r.RestaurantId != updateRestaurantDTO.RestaurantId))
                {
                    return new ApiResponse<ConfirmationResponseDTO>(400, "Restaurant name already exists.");
                }

                restaurant.Name = updateRestaurantDTO.Name;
                restaurant.AddressLineOne = updateRestaurantDTO.AddressLineOne;
                restaurant.AddressLineTwo = updateRestaurantDTO.AddressLineTwo;
                restaurant.City = updateRestaurantDTO.City;
                restaurant.PostCode = updateRestaurantDTO.PostCode;
                restaurant.PhoneNumber = updateRestaurantDTO.PhoneNumber;
                restaurant.DaysOfWeek = updateRestaurantDTO.DaysOfWeek;
                restaurant.OpeningTime = updateRestaurantDTO.OpeningTime;
                restaurant.ClosingTime = updateRestaurantDTO.ClosingTime;
                restaurant.NumbersOfTables = updateRestaurantDTO.NumbersOfTables;
                restaurant.Logo = updateRestaurantDTO.Logo;
                restaurant.LastUpdatedDate = updateRestaurantDTO.LastUpdatedDate;

                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"Restaurant with Id {updateRestaurantDTO.RestaurantId} updated successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> DeleteRestaurantAsync(long id)
        {
            try
            {
                var restaurant = await _applicationDbContext.Restaurants
                    .Include(r => r.MenuItem)
                    .Include(r => r.Cuisine)
                    .Include(r => r.Feedback)
                    .Include(r => r.Reservation)
                    .FirstOrDefaultAsync(r => r.RestaurantId == id);

                if (restaurant == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "Restaurant not found.");
                }

                restaurant.IsDeleted = true;
                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"The restaurant with Id {id} was successfully deleted."
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
