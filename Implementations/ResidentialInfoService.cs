using DataAccessLayer;
using ApplicationDomain;
using Interfaces;

namespace Implementations
{
    public class ResidentialInfoService : IResidentialInfoService
    {
        private readonly IDbRepository _dbRepository;

        public ResidentialInfoService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        public async Task<ResidentialInfo> GetResidentialInfoAsync(int personalInfoId)
        {
            return await _dbRepository.GetResidentialInfoAsync(personalInfoId);
        }

        public async Task ChangeCityAsync(int userId, string email)
        {
            await _dbRepository.ChangeCityAsync(userId, email);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task ChangeStreetAsync(int userId, string street)
        {
            await _dbRepository.ChangeStreetAsync(userId, street);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task ChangeHouseNumberAsync(int userId, string houseNumber)
        {
            await _dbRepository.ChangeHouseNumberAsync(userId, houseNumber);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task ChangeApartmentNumberAsync(int userId, string apartmentNumber)
        {
            await _dbRepository.ChangeApartmentNumber(userId, apartmentNumber);
            await _dbRepository.SaveChangesAsync();
        }
    }
}
