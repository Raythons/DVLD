using DVLD.Domain.Entities;

namespace DLVD.App.Features.Common.SharedDtos
{

    public class GetDriverDto
    {

        public int Id { get; set; }
        public int PersonId { get; set; }
        public int CreatedByUserId { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ActiveLicense { get; set; }


    }
}