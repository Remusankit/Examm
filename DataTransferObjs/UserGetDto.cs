
namespace DataTransferObjs
{
    public class UserGetDto
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string PersonalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string StreetName { get;set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public byte[] ProfilePic { get; set; }
    }
}
