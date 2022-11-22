using ApplicationDomain;

namespace DataAccessLayer
{
    public interface IDbRepository
    {
        Task<User?> GetUserByUsernameAsync(string username);
        Task InsertAccountAsync(User user);
        Task SaveChangesAsync();
        Task<Image> AddImageAsync(Image image);
        Task<Image> GetImageAsync(int id);
        Task<Image> GetImageByUserIdAsync(int userId);
        Task<User> GetUserByIdAsync(int id);
        Task<PersonalInfo> GetPersonalInfoAsync(int userId);
        Task<ResidentialInfo> GetResidentialInfoAsync(int personalInfoId);
        Task ChangeNameAsync(int userId, string name);
        Task ChangeLastnameAsync(int userId, string lastname);
        Task ChangePersonalCodeAsync(int userId, string personalCode);
        Task ChangePhoneAsync(int userId, string phone);
        Task ChangeEmailAsync(int userId, string email);
        Task ChangeCityAsync(int userId, string city);
        Task ChangeStreetAsync(int userId, string street);
        Task ChangeHouseNumberAsync(int userId, string houseNumber);
        Task ChangeApartmentNumber(int userId, string apartmentNumber);
        Task DeleteUserAsync(User user);
        Task ChangeProfilePicAsync(int userId, byte[] imageBytes, string contentType);
    }
}
