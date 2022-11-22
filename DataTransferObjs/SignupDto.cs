
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DataTransferObjs
{
    public class SignupDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public PersonalInfoDto PersonalInfo { get; set; }
    }
}
