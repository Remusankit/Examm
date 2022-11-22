using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PersonManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressIDetailsController : ControllerBase
    {
        private readonly IResidentialInfoService _residentialInfoService;

        public AddressIDetailsController(IResidentialInfoService residentialInfoService)
        {
            _residentialInfoService = residentialInfoService;
        }

        [HttpPut("UpdateCity")]
        [Authorize]
        public async Task<IActionResult> UpdateCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                return BadRequest("Info can't be null or whistespace");
            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            await _residentialInfoService.ChangeCityAsync(userId, city);
            return Ok();
        }

        [HttpPut("UpdateStreet")]
        [Authorize]
        public async Task<IActionResult> UpdateStreet(string street)
        {
            if (string.IsNullOrWhiteSpace(street))
            {
                return BadRequest("Info can't be null or whistespace");
            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            await _residentialInfoService.ChangeStreetAsync(userId, street);
            return Ok();
        }

        [HttpPut("UpdateHouseNumber")]
        [Authorize]
        public async Task<IActionResult> UpdateHouseNumber(string houseNumber)
        {
            if (string.IsNullOrWhiteSpace(houseNumber))
            {
                return BadRequest("Info can't be null or whistespace");
            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            await _residentialInfoService.ChangeHouseNumberAsync(userId, houseNumber);
            return Ok();
        }

        [HttpPut("UpdateFlatNumber")]
        [Authorize]
        public async Task<IActionResult> UpdateFlatNumber(string apartmentNumber)
        {
            if (string.IsNullOrWhiteSpace(apartmentNumber))
            {
                return BadRequest("Info can't be null or whistespace");
            }
            var userId = int.Parse(User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value);
            await _residentialInfoService.ChangeApartmentNumberAsync(userId, apartmentNumber);
            return Ok();
        }
    }
}
