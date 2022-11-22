using DataTransferObjs;
using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonManagementSystem.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
   public class LogInAndSignUpController : ControllerBase
    {
        private readonly IUsersService _userService;
        private readonly IJwtService _jwtService;
        private readonly IImageService _imageService;

        public LogInAndSignUpController(IUsersService usersService, IJwtService jwtService, IImageService imageService)
        {
            _userService = usersService;
            _jwtService = jwtService;
            _imageService = imageService;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignupDto signupDto)
        {
            try
            {
                var resizedImage = await _imageService.GetImageBytesAsync(signupDto);
                var savedImage = await _imageService.AddImageAsync(resizedImage, signupDto.PersonalInfo.ProfilePic.ContentType);
                var success = await _userService.CreateUserAsync(signupDto.Username, signupDto.Password, signupDto.PersonalInfo, signupDto.PersonalInfo.ResidentialInfo, savedImage);
                return success ? Ok() : BadRequest(new { ErrorMessage = "User with this username already exists" });

            }
            catch (Exception ex)
            {
                return BadRequest(new { ErrorMessage = "Registration failed" });
            }

        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var (loginSuccess, user) = await _userService.LoginAsync(loginDto.Username, loginDto.Password);
            if (loginSuccess)
            {
                return Ok(new { Token = _jwtService.GetJwtToken(user) });
                { }
            }
            else
            {
                return BadRequest(new { ErrorMessage = "Login failed" });
            }
        }
    }
}
