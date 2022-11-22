using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PersonManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   public class BiodataController : ControllerBase
    {
        private readonly IPersonalInfoService _personalInfoService;

        public BiodataController(IPersonalInfoService personalInfoService)
        {
            _personalInfoService = personalInfoService;
        }

        [HttpPut("UpdateName")]
        [Authorize]
        public async Task<IActionResult> UpdateNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Info can't be null or whistespace");

            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            await _personalInfoService.ChangeNameAsync(userId, name);
            return Ok();
        }

        [HttpPut("UpdateSurename")]
        [Authorize]
        public async Task<IActionResult> UpdateSurenameAsync(string lastname)
        {
            if (string.IsNullOrWhiteSpace(lastname))
            {
                return BadRequest("Info can't be null or whistespace");
            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            await _personalInfoService.ChangeLastnameAsync(userId, lastname);
            return Ok();
        }

        [HttpPut("UpdatePersonCode")]
        [Authorize]
        public async Task<IActionResult> UpdatePersonalCodeAsync(string personalCode)
        {
            if (string.IsNullOrWhiteSpace(personalCode))
            {
                return BadRequest("Info can't be null or whistespace");
            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            await _personalInfoService.ChangePersonalCodeAsync(userId, personalCode);
            return Ok();
        }

        [HttpPut("UpdatePhoneNumber")]
        [Authorize]
        public async Task<IActionResult> UpdatePhoneAsync(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return BadRequest("Info can't be null or whistespace");
            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            await _personalInfoService.ChangePhoneAsync(userId, phoneNumber);
            return Ok();
        }

        [HttpPut("UpdateEmail")]
        [Authorize]
        public async Task<IActionResult> UpdateEmailAsync(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return BadRequest("Info can't be null or whistespace");
            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            await _personalInfoService.ChangeEmailAsync(userId, email);
            return Ok();
        }
    }
}
