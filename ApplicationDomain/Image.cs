using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDomain
{
    public class Image
    {
        public int Id { get; set; }
        [ForeignKey("PersonalInfo")]
        public int? PersonalInfoId { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }
        public string ContentType { get; set; }
        public byte[] ImageBytes { get; set; }
        
        public Image()
        {

        }
    }
}
