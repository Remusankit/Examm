using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ApplicationDomain
{
    public class PersonalInfo
    {       
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string PersonalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Image ProfilePic { get; set; }
        public ResidentialInfo ResidentialInfo { get; set; }

        public PersonalInfo()
        {

        }
    }
}
