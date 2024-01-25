using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using ComicWebApplication.Helpers;
using Microsoft.Extensions.Options;

namespace ComicWebApplication.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly Cloudinary _cloudinary;
        public PhotoService(IOptions<CloudinarySettings> config)
        {
            var acc = new Account(
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret
                );
            _cloudinary = new Cloudinary(acc);
        }
        public async Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
        {
            var uploadPhoto = new ImageUploadResult();
            if(file.Length > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Transformation = new Transformation().Height(500).Width(500).Crop("fill").Gravity("face")
                };
                uploadPhoto = await _cloudinary.UploadAsync(uploadParams);
            }
            else
            {
                return uploadPhoto;
            }
            return uploadPhoto;  
        }
    }
}
