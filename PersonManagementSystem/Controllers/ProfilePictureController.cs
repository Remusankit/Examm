using DataTransferObjs;
using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PersonManagementSystem.Controllers
{
    [Route("api/[controller]")]
   public class ProfilePictureController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ProfilePictureController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet("GetImageByImageId")]
        [Authorize]
        public async Task<IActionResult> GetImageByImageId(int imageId)
        {
            var image = await _imageService.GetImageAsync(imageId);
            return File(image.ImageBytes, image.ContentType);
        }

        [HttpGet("GetImageByPersonId")]
        [Authorize]
        public async Task<IActionResult> GetImageByPersonId()
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            var image = await _imageService.GetImageByUserIdAsync(userId);
            return File(image.ImageBytes, image.ContentType);
        }

        [HttpPut("ChangeProfilePicture")]
        [Authorize]
        public async Task<IActionResult> ChangeProfilePic(ImageUploadDto imageDto)
        {
            if (imageDto == null)
            {
                return BadRequest("Need to upload picture");
            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            var imageBytes = await _imageService.GetImageBytesForProfilePicChangeAsync(imageDto);
            var contentType = imageDto.ProfilePic.ContentType;

            await _imageService.ChangeProfilePicAsync(userId, imageBytes, contentType);

            return Ok();
        }
    }
}
