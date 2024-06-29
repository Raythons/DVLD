using DLVD.App.Features.Common.Converters;
using DVLD.Domain.Enums;
using System.Text.Json.Serialization;


namespace DLVD.App.Features.Common.SharedDtos
{
    public class GetPersonDetailsDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationalNo { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        [JsonConverter(typeof(EnGednerJsonConverter))]
        public EnGender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
    }
}
