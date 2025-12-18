using CloudinaryDotNet.Actions;
using FoodFusion.Server.FileUploader;

namespace FoodFusion.Server.Services.Interfaces
{
    public interface IFileUploaderService
    {
        Task<ImageUploadResult> AddFileAsync (IFormFile file);
        Task<string> DeleteFileAsync (string publicId);
    }
}
