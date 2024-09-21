using FluentResults;
using MediatR;
using System.Text.Json.Serialization;


namespace DLVD.App.Features.Licenses.Command.DetainLicense
{
    public class DetainLicenseRequest: IRequest<Result<DetainLicenseResponse>>
    {
        public int LicenseId { get; set; }

        [JsonIgnore]
        public DateTime DetainDate { get;  } = DateTime.Now;
        public float FineFees { get; set; }
        [JsonIgnore]
        public int CreatedByUserId { get; set; }
        [JsonIgnore]
        public bool IsReleased { get; set; } = false;
        
        public DetainLicenseRequest(
            int licenseId,
            float fineFees)
        {
            LicenseId = licenseId;
            FineFees = fineFees;
        }

       
    }
}
