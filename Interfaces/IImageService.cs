using DataTransferObjs;
using ApplicationDomain;
//using FinalExam.DTOs;

namespace Interfaces
{
    public interface IImageService
    {
        Task<Image> AddImageAsync(byte[] imageBytes,  string contentType);
        Task<Image> GetImageAsync(int id);
        Task<Image> GetImageByUserIdAsync(int userId);
        Task<byte[]> ResizeImage(byte[] imageBytes, string contentType);
        Task<byte[]> GetImageBytesAsync(SignupDto dto);
        Task<byte[]> GetImageBytesForProfilePicChangeAsync(ImageUploadDto imageDto);
        Task ChangeProfilePicAsync(int userId, byte[] imageBytes, string contentType);
    }
}
