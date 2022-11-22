using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDomain
{
    public class ResidentialInfo
    {       
        public int Id { get; set; }
        [ForeignKey("PersonalInfo")]
        public int PersonalInfoId { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }

        public ResidentialInfo()
        {

        }
    }
}
