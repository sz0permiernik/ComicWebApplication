using CloudinaryDotNet.Actions;

namespace ComicWebApplication.Services
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
    }
}
