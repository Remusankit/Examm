using DataTransferObjs;
using ApplicationDomain;
//using FinalExam.DTOs;

namespace Interfaces
{
    public interface IUsersService
    {
        Task<bool> CreateUserAsync(string username, string password, PersonalInfoDto personalInfo, ResidentialInfoDto residentialInfo, Image image);
        Task<(bool authenticationSuccessful, User? user)> LoginAsync(string username, string password);
        Task<User> GetUserByIdAsync(int id);
        Task DeleteUserAsync(int userId);
    }
}
