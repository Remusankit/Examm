
namespace ApplicationDomain
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
        public PersonalInfo PersonalInfo { get; set; } 

        public User()
        {

        }
    }
}
