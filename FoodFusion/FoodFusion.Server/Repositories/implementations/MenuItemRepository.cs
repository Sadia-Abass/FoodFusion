using FoodFusion.Server.Data;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MenuItemDTOs;
using FoodFusion.Server.DTOs.RestaurantDTO;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.Interfaces;
using FoodFusion.Server.Services.Impelementation;
using FoodFusion.Server.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Repositories.implementations
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly ICuisineRepository _cuisineRepository;
        private readonly IDishTypeRepository _dishTypeRepository;
        private readonly IMealCourseRepository _mealCourseRepository;
        private readonly IMealTypeRepository _mealTypeRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IFileUploaderService _fileUploaderService;
        private readonly ApplicationDbContext _applicationDbContext;
        private int pageNumber = 1;
        private int pageSize = 20;

        public MenuItemRepository(ICuisineRepository cuisineRepository, IDishTypeRepository dishTypeRepository, IMealCourseRepository mealCourseRepository, IMealTypeRepository mealTypeRepository, IRestaurantRepository restaurantRepository, IFileUploaderService fileUploaderService, ApplicationDbContext applicationDbContext)
        {
            _cuisineRepository = cuisineRepository ?? throw new ArgumentNullException(nameof(cuisineRepository));
            _dishTypeRepository = dishTypeRepository ?? throw new ArgumentNullException(nameof(dishTypeRepository));
            _mealCourseRepository = mealCourseRepository ?? throw new ArgumentNullException(nameof(mealCourseRepository));
            _mealTypeRepository = mealTypeRepository ?? throw new ArgumentNullException(nameof(mealTypeRepository));
            _restaurantRepository = restaurantRepository ?? throw new ArgumentNullException(nameof(restaurantRepository));
            _fileUploaderService = fileUploaderService ?? throw new ArgumentNullException(nameof(fileUploaderService));
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<ApiResponse<MenuItemResponseDTO>> CreateMenuItemAsync(CreateMenuItemDTO createMenuItemDTO)
        {
            try
            {
                var imageToUpload = await _fileUploaderService.AddFileAsync(createMenuItemDTO.ImageUrl);

                var menuItem = new MenuItem
                {
                    Name = createMenuItemDTO.Name,
                    Description = createMenuItemDTO.Description,
                    Price = createMenuItemDTO.Price,
                    Calories = createMenuItemDTO.Calories,
                    PreparationTimeInMinutes = createMenuItemDTO.PreparationTimeInMinutes,
                    Allergens = createMenuItemDTO.Allergens,
                    ImageUrl = imageToUpload.SecureUrl.ToString(),
                    IsAvailable = createMenuItemDTO.IsAvailable,
                    CreatedDate = DateTime.UtcNow,
                    RestaurantId = createMenuItemDTO.RestaurantId,
                    CuisineId = createMenuItemDTO.CuisineId,
                    MealCourseId = createMenuItemDTO.MealCourseId,
                    MealTypeId = createMenuItemDTO.MealTypeId,
                    MenuItemDishTypes = new List<MenuItemDishType>()
                };

                foreach(var dishTypeId in createMenuItemDTO.DishTypeIds)
                {
                    if (await _dishTypeRepository.ExistsAsync(dishTypeId))
                    {
                        menuItem.MenuItemDishTypes.Add(new MenuItemDishType
                        {
                            DishTypeId = dishTypeId,
                        });
                    } 
                }

                await _applicationDbContext.MenuItems.AddAsync(menuItem);
                await _applicationDbContext.SaveChangesAsync();

                var menuItemResponse = new MenuItemResponseDTO
                {
                    MenuItemID = menuItem.MenuItemID,
                    Name = menuItem.Name,
                    Description = menuItem.Description,
                    Price = menuItem.Price,
                    Calories = menuItem.Calories,
                    PreparationTimeInMinutes = menuItem.PreparationTimeInMinutes,
                    Allergens = menuItem.Allergens,
                    ImageUrl = menuItem.ImageUrl,
                    IsAvailable = menuItem.IsAvailable
                };

                return new ApiResponse<MenuItemResponseDTO>(200, menuItemResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<MenuItemResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> DeleteMenuItemAsync(long id)
        {
            try
            {
                var menuItem = await _applicationDbContext.MenuItems
                   .Include(r => r.Restaurant)
                   .Include(c => c.Cuisine)
                   .Include(m => m.MealCourse)
                   .Include(m => m.MealType)
                   .Include(m => m.MenuItemDishTypes)
                   .ThenInclude(md => md.DishType)
                   .FirstOrDefaultAsync(m => m.MenuItemID == id);

                if (menuItem == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "MenuItem not found.");
                }

                menuItem.IsDeleted = true;
                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"The menuItem with Id {id} was successfully deleted."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
          
        }

        public async Task<ApiResponse<PaginationResult<MenuItemListDTO>>> GetAllMenuItemAsync()
        {
            try
            {
                var listOfMenuItems = await _applicationDbContext.MenuItems.AsNoTracking()
                    .Include(r => r.Restaurant)
                    .Include(c => c.Cuisine)
                    .Include(m => m.MealCourse)
                    .Include(m => m.MealType)
                    .Include(m => m.MenuItemDishTypes)
                    .ThenInclude(md => md.DishType)
                    .Where(m => m.IsDeleted)
                    .ToListAsync();

                var menuList = new PaginationResult<MenuItemListDTO>
                {
                    Items = listOfMenuItems.Select(m => new MenuItemListDTO
                    {
                        MenuItemID = m.MenuItemID,
                        Name = m.Name,
                        Description = m.Description,
                        Price = m.Price,
                        Calories = m.Calories,
                        PreparationTimeInMinutes = m.PreparationTimeInMinutes,
                        Allergens = m.Allergens,
                        IsAvailable = m.IsAvailable,
                        ImageUrl = m.ImageUrl,
                        CuisineName = m.Cuisine?.Name ?? string.Empty,
                        MealCourseName = m.MealCourse?.Name ?? string.Empty,
                        MealTypeName = m.MealType?.Name ?? string.Empty,
                        DishTypeNames = m.MenuItemDishTypes?.Select(md => md.DishType.Name).ToList() ?? new List<string>()
                    }).ToList(),
                    TotalCount = listOfMenuItems.Count,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                };

                return new ApiResponse<PaginationResult<MenuItemListDTO>>(200, menuList);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<PaginationResult<MenuItemListDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<MenuItemResponseDTO>> GetMenuItemByIdAsync(long id)
        {
            try
            {
                var menuItem = await _applicationDbContext.MenuItems.AsNoTracking().FirstOrDefaultAsync(m => m.MenuItemID == id);

                if (menuItem == null) 
                {
                    return new ApiResponse<MenuItemResponseDTO>(404, "MenuItem not found.");
                }

                var menuItemResponse = new MenuItemResponseDTO
                {
                    MenuItemID = menuItem.MenuItemID,
                    Name = menuItem.Name,
                    Description = menuItem.Description,
                    Price = menuItem.Price,
                    Calories = menuItem.Calories,
                    PreparationTimeInMinutes = menuItem.PreparationTimeInMinutes,
                    Allergens = menuItem.Allergens,
                    IsAvailable = menuItem.IsAvailable,
                    ImageUrl = menuItem.ImageUrl
                };

                return new ApiResponse<MenuItemResponseDTO>(200, menuItemResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<MenuItemResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }


        public async Task<ApiResponse<ConfirmationResponseDTO>> UpdateMenuItemAsync(UpdateMenuItemDTO updateMenuItemDTO)
        {
           
            try
            {
                var menuItem = await _applicationDbContext.MenuItems.FindAsync(updateMenuItemDTO.MenuItemID);
                if (menuItem == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "MenuItem not found.");
                }

                string imageInDto = updateMenuItemDTO.ImageUrl.ToString();

                if (!string.IsNullOrEmpty(menuItem.ImageUrl) && !string.IsNullOrEmpty(imageInDto) && menuItem.ImageUrl != imageInDto)
                {
                    await _fileUploaderService.DeleteFileAsync(menuItem.ImageUrl);
                }

                var newUploadedImage = await _fileUploaderService.AddFileAsync(updateMenuItemDTO.ImageUrl);

                menuItem.Name = updateMenuItemDTO.Name;
                menuItem.Description = updateMenuItemDTO.Description;
                menuItem.Price = updateMenuItemDTO.Price;
                menuItem.Calories = updateMenuItemDTO.Calories;
                menuItem.PreparationTimeInMinutes = updateMenuItemDTO.PreparationTimeInMinutes;
                menuItem.Allergens = updateMenuItemDTO.Allergens;
                menuItem.IsAvailable = updateMenuItemDTO.IsAvailable;
                menuItem.ImageUrl = newUploadedImage.SecureUrl.ToString();
                menuItem.ModifiedDate = DateTime.UtcNow;

                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"MenuItem with Id {updateMenuItemDTO.MenuItemID} updated successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<List<MenuItemListDTO>>> GetMenuItemByCuisineAsync(long cuisineId)
        {
            try
            {
                var menuItems = await _applicationDbContext.MenuItems.AsNoTracking()
                    .Include(r => r.Restaurant)
                    .Include(c => c.Cuisine)
                    .Include(m => m.MealCourse)
                    .Include(m => m.MealType)
                    .Include(m => m.MenuItemDishTypes)
                    .ThenInclude(md => md.DishType)
                    .Where(m => m.CuisineId == cuisineId && m.IsDeleted)
                    .ToListAsync();

                if(menuItems == null || menuItems.Count == 0)
                {
                    return new ApiResponse<List<MenuItemListDTO>>(404, "MenuItem not found.");
                }

                var listOfMenuItem = menuItems.Select(m => new MenuItemListDTO
                {
                    MenuItemID = m.MenuItemID,
                    Name = m.Name,
                    Description = m.Description,
                    Price = m.Price,
                    Calories = m.Calories,
                    PreparationTimeInMinutes = m.PreparationTimeInMinutes,
                    Allergens = m.Allergens,
                    IsAvailable = m.IsAvailable,
                    ImageUrl = m.ImageUrl,
                    CuisineName = m.Cuisine?.Name ?? string.Empty,
                    MealCourseName = m.MealCourse?.Name ?? string.Empty,
                    MealTypeName = m.MealType?.Name ?? string.Empty,
                    DishTypeNames = m.MenuItemDishTypes?.Select(md => md.DishType.Name).ToList() ?? new List<string>()
                }).OrderBy(m => m.Name).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

                return new ApiResponse<List<MenuItemListDTO>>(200, listOfMenuItem);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<MenuItemListDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

 


        public async Task<ApiResponse<List<MenuItemListDTO>>> GetMenuItemByDishTypeAsync(long dishTypeId)
        {
            try
            {
                var menuItems = await _applicationDbContext.MenuItems.AsNoTracking()
                    .Include(r => r.Restaurant)
                    .Include(c => c.Cuisine)
                    .Include(m => m.MealCourse)
                    .Include(m => m.MealType)
                    .Include(m => m.MenuItemDishTypes)
                    .ThenInclude(md => md.DishType)
                    .Where(m => m.MenuItemDishTypes.Any(d => d.DishTypeId == dishTypeId) && m.IsDeleted)
                    .ToListAsync();

                if (menuItems == null || menuItems.Count == 0)
                {
                    return new ApiResponse<List<MenuItemListDTO>>(404, "MenuItem not found.");
                }

                var listOfMenuItem = menuItems.Select(m => new MenuItemListDTO
                {
                    MenuItemID = m.MenuItemID,
                    Name = m.Name,
                    Description = m.Description,
                    Price = m.Price,
                    Calories = m.Calories,
                    PreparationTimeInMinutes = m.PreparationTimeInMinutes,
                    Allergens = m.Allergens,
                    IsAvailable = m.IsAvailable,
                    ImageUrl = m.ImageUrl,
                    CuisineName = m.Cuisine?.Name ?? string.Empty,
                    MealCourseName = m.MealCourse?.Name ?? string.Empty,
                    MealTypeName = m.MealType?.Name ?? string.Empty,
                    DishTypeNames = m.MenuItemDishTypes?.Select(md => md.DishType.Name).ToList() ?? new List<string>()
                }).OrderBy(m => m.Name).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

                return new ApiResponse<List<MenuItemListDTO>>(200, listOfMenuItem);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<MenuItemListDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        } 

        public async Task<ApiResponse<List<MenuItemListDTO>>> GetMenuItemByMealCourseAsync(long mealCourseId)
        {
            try
            {
                var menuItems = await _applicationDbContext.MenuItems.AsNoTracking()
                    .Include(r => r.Restaurant)
                    .Include(c => c.Cuisine)
                    .Include(m => m.MealCourse)
                    .Include(m => m.MealType)
                    .Include(m => m.MenuItemDishTypes)
                    .ThenInclude(md => md.DishType)
                    .Where(m => m.MealCourseId == mealCourseId && m.IsDeleted)
                    .ToListAsync();

                if (menuItems == null || menuItems.Count == 0)
                {
                    return new ApiResponse<List<MenuItemListDTO>>(404, "MenuItem not found.");
                }

                var listOfMenuItem = menuItems.Select(m => new MenuItemListDTO
                {
                    MenuItemID = m.MenuItemID,
                    Name = m.Name,
                    Description = m.Description,
                    Price = m.Price,
                    Calories = m.Calories,
                    PreparationTimeInMinutes = m.PreparationTimeInMinutes,
                    Allergens = m.Allergens,
                    IsAvailable = m.IsAvailable,
                    ImageUrl = m.ImageUrl,
                    CuisineName = m.Cuisine?.Name ?? string.Empty,
                    MealCourseName = m.MealCourse?.Name ?? string.Empty,
                    MealTypeName = m.MealType?.Name ?? string.Empty,
                    DishTypeNames = m.MenuItemDishTypes?.Select(md => md.DishType.Name).ToList() ?? new List<string>()
                }).OrderBy(m => m.Name).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

                return new ApiResponse<List<MenuItemListDTO>>(200, listOfMenuItem);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<MenuItemListDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<List<MenuItemListDTO>>> GetMenuItemByMealTypeAsync(long mealTypeId)
        {
            try
            {
                var menuItems = await _applicationDbContext.MenuItems.AsNoTracking()
                    .Include(r => r.Restaurant)
                    .Include(c => c.Cuisine)
                    .Include(m => m.MealCourse)
                    .Include(m => m.MealType)
                    .Include(m => m.MenuItemDishTypes)
                    .ThenInclude(md => md.DishType)
                    .Where(m => m.MealTypeId == mealTypeId && m.IsDeleted)
                    .ToListAsync();

                if (menuItems == null || menuItems.Count == 0)
                {
                    return new ApiResponse<List<MenuItemListDTO>>(404, "MenuItem not found.");
                }

                var listOfMenuItem = menuItems.Select(m => new MenuItemListDTO
                {
                    MenuItemID = m.MenuItemID,
                    Name = m.Name,
                    Description = m.Description,
                    Price = m.Price,
                    Calories = m.Calories,
                    PreparationTimeInMinutes = m.PreparationTimeInMinutes,
                    Allergens = m.Allergens,
                    IsAvailable = m.IsAvailable,
                    ImageUrl = m.ImageUrl,
                    CuisineName = m.Cuisine?.Name ?? string.Empty,
                    MealCourseName = m.MealCourse?.Name ?? string.Empty,
                    MealTypeName = m.MealType?.Name ?? string.Empty,
                    DishTypeNames = m.MenuItemDishTypes?.Select(md => md.DishType.Name).ToList() ?? new List<string>()
                }).OrderBy(m => m.Name).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

                return new ApiResponse<List<MenuItemListDTO>>(200, listOfMenuItem);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<MenuItemListDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

     
    }
}
