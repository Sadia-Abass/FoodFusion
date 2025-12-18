using FoodFusion.Server.Data;
using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MenuItemImageDTOs;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.Interfaces;
using FoodFusion.Server.Services.Impelementation;
using Microsoft.EntityFrameworkCore;

namespace FoodFusion.Server.Repositories.implementations
{
    public class MenuItemImageRepository : IMenuItemImageRepository
    {
        private readonly FileUploaderService _fileUploaderService;
        private readonly ApplicationDbContext _applicationDbContext;

        public MenuItemImageRepository(FileUploaderService fileUploaderService, ApplicationDbContext applicationDbContext)
        {
            _fileUploaderService = fileUploaderService ?? throw new ArgumentNullException(nameof(fileUploaderService));
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async Task<ApiResponse<List<MenuItemImageResponseDTO>>> GetMenuItemImageAsync()
        {
            try
            {
                var menuItemImage = await _applicationDbContext.MenuItemImages.AsNoTracking().ToListAsync();

                var images = menuItemImage.Select(i => new MenuItemImageResponseDTO
                {
                    MenuItemImageID = i.MenuItemImageID,
                    ImageUrl = i.ImageUrl,
                    MenuItem = i.MenuItem
                }).ToList();

                return new ApiResponse<List<MenuItemImageResponseDTO>>(200, images);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<List<MenuItemImageResponseDTO>>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<MenuItemImageResponseDTO>> GetMenuItemImageByIdAsnc(long id)
        {
            try
            {
                var menuItemImage = await _applicationDbContext.MenuItemImages.AsNoTracking().FirstOrDefaultAsync(i => i.MenuItemImageID == id);

                if(menuItemImage == null)
                {
                    return new ApiResponse<MenuItemImageResponseDTO>(404, "Menu image not found.");
                }

                var imageResult = new MenuItemImageResponseDTO
                {
                    MenuItemImageID = menuItemImage.MenuItemImageID,
                    ImageUrl = menuItemImage.ImageUrl,
                    MenuItem = menuItemImage.MenuItem
                };

                return new ApiResponse<MenuItemImageResponseDTO>(200, imageResult);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<MenuItemImageResponseDTO>(500, $"n unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<MenuItemImageResponseDTO>> CreateMenuItemImageAsync(CreateMenuItemImageDTO createMenuItemImageDTO)
        {
            try
            {
                var imageUpload = await _fileUploaderService.AddFileAsync(createMenuItemImageDTO.ImageUrl);

                var menuItemImage = new MenuItemImage
                {
                    ImageUrl = imageUpload.Url.ToString(),
                    CreatedDate = DateTime.UtcNow
                };

                await _applicationDbContext.AddAsync(menuItemImage);
                await _applicationDbContext.SaveChangesAsync();

                var menuItemImageUploadResponse = new MenuItemImageResponseDTO
                {
                    MenuItemImageID = menuItemImage.MenuItemImageID,
                    ImageUrl = menuItemImage.ImageUrl,
                    MenuItem = menuItemImage.MenuItem
                };

                return new ApiResponse<MenuItemImageResponseDTO>(200, menuItemImageUploadResponse);
            }
            catch (Exception ex) 
            {
                return new ApiResponse<MenuItemImageResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> UpdateMenuItemImageAsync(UpdateMenuItemImageDTO updateMenuItemImageDTO)
        {
            try
            {
                var menuItemImage = await _applicationDbContext.MenuItemImages.FindAsync(updateMenuItemImageDTO.MenuItemImageID);
                if(menuItemImage == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "Image not found.");
                }

                var deleteParams = await _fileUploaderService.DeleteFileAsync(menuItemImage.ImageUrl);

                var imageResult = await _fileUploaderService.AddFileAsync(updateMenuItemImageDTO.ImageUrl);

                menuItemImage.MenuItemImageID = updateMenuItemImageDTO.MenuItemImageID;
                menuItemImage.ImageUrl = imageResult.Url.ToString();

                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"MenuItem image with Id {updateMenuItemImageDTO.MenuItemImageID} was updated successfully."
                };

                return new ApiResponse<ConfirmationResponseDTO>(200, confirmationMessage);
         
            }
            catch(Exception ex) 
            {
                return new ApiResponse<ConfirmationResponseDTO>(500, $"An unexpected error occurred while processing your request, Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<ConfirmationResponseDTO>> DeleteMenuItemImageAsync(long id)
        {
            try
            {
                var menuItemImage = await _applicationDbContext.MenuItemImages.FirstOrDefaultAsync(i => i.MenuItemImageID == id);
                if (menuItemImage == null)
                {
                    return new ApiResponse<ConfirmationResponseDTO>(404, "MenuItem image not found.");
                }

                var deleteParam = await _fileUploaderService.DeleteFileAsync(menuItemImage.ImageUrl);

                menuItemImage.ImageUrl = string.Empty;
                menuItemImage.IsDeleted = true;
                await _applicationDbContext.SaveChangesAsync();

                var confirmationMessage = new ConfirmationResponseDTO
                {
                    Message = $"MenuItem image with Id {id} was successfully deleted."
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
