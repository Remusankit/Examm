using DataAccessLayer;
using ApplicationDomain;
using Interfaces;

namespace Implementations
{
    public class PersonalInfoService : IPersonalInfoService
    {
        private readonly IDbRepository _dbRepository;

        public PersonalInfoService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        public async Task ChangeNameAsync(int userId, string name)
        {
            await _dbRepository.ChangeNameAsync(userId, name);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task ChangeLastnameAsync(int userId, string lastname)
        {
            await _dbRepository.ChangeLastnameAsync(userId, lastname);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task ChangePersonalCodeAsync(int userId, string personalCode)
        {
            await _dbRepository.ChangePersonalCodeAsync(userId, personalCode);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task ChangePhoneAsync(int userId, string phoneNumber)
        {
            await _dbRepository.ChangePhoneAsync(userId, phoneNumber);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task ChangeEmailAsync(int userId, string email)
        {
            await _dbRepository.ChangeEmailAsync(userId, email);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task<PersonalInfo> GetPersonalInfoAsync(int userId)
        {
            return await _dbRepository.GetPersonalInfoAsync(userId);
        }
    }
}
