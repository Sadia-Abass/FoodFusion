using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using FoodFusion.Server.Configurations;
using FoodFusion.Server.FileUploader;
using FoodFusion.Server.Services.Interfaces;
using Microsoft.Extensions.Options;

namespace FoodFusion.Server.Services.Impelementation
{
    public class FileUploaderService : IFileUploaderService
    {
        private readonly Cloudinary _cloudinary;

        public FileUploaderService(IOptions<CloudinarySettings> cloudinarySettings)
        {
            var account = new Account(
                cloudinarySettings.Value.CloudName,
                cloudinarySettings.Value.ApiKey,
                cloudinarySettings.Value.ApiSecret
                );

            _cloudinary = new Cloudinary(account);
        }

        public async Task<ImageUploadResult> AddFileAsync(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();

            if (file.Length > 0) 
            {
                using var stream = file.OpenReadStream();
                var uploadParam = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Folder = "FusionFood",
                    Transformation = new Transformation().Height(500).Width(500)
                };

                uploadResult = await _cloudinary.UploadAsync(uploadParam);
                //if (uploadResult.Error != null) 
                //{
                //    throw new Exception(uploadResult.Error.Message);
                //}

                //return new FileUploaderResult
                //{
                //    PublicId = uploadResult.PublicId,
                //    Url = uploadResult.SecureUrl.ToString()
                //};
            }

            return uploadResult;
        }

        public async Task<string> DeleteFileAsync(string publicId)
        {
            var deletedParams = new DeletionParams(publicId);
            var result = await _cloudinary.DestroyAsync(deletedParams);
            return result.Result == "OK" ? result.Result : null;
        }
    }
}
