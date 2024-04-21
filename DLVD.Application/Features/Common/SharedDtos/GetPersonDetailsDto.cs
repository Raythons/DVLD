using DVLD.Domain.Enums;


namespace DLVD.App.Features.Common.SharedDtos
{
    public class GetPersonDetailsDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationalNo { get; set; }
        public int Age { get; set; }
        public EnGender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[]? Image { get; set; }
    }
}
