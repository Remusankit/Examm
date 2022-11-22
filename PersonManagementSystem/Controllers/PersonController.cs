using DataTransferObjs;
using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;

namespace PersonManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IUsersService _userService;

        public PersonController(IUsersService usersService)
        {
            _userService = usersService;
        }

        [HttpGet("GetPersonDetails")]
        [Authorize]
        public async Task<IActionResult> GetPersonDetails()
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            var user = await _userService.GetUserByIdAsync(userId);

            var infoToReturn = new UserGetDto
            {
                Username = user.Username,
                Role = user.Role,
                Name = user.PersonalInfo.Name,
                Lastname = user.PersonalInfo.Lastname,
                PersonalCode = user.PersonalInfo.PersonalCode,
                Phone = user.PersonalInfo.Phone,
                Email = user.PersonalInfo.Email,
                City = user.PersonalInfo.ResidentialInfo.City,
                StreetName = user.PersonalInfo.ResidentialInfo.StreetName,
                HouseNumber = user.PersonalInfo.ResidentialInfo.HouseNumber,
                ApartmentNumber = user.PersonalInfo.ResidentialInfo.ApartmentNumber,
                ProfilePic = user.PersonalInfo.ProfilePic.ImageBytes
            };
            return Ok(infoToReturn);
        }

        [HttpDelete("DeleteUser")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeletePerson(int userId)
        {
            await _userService.DeleteUserAsync(userId);
            return Ok();
        }
    }
}
