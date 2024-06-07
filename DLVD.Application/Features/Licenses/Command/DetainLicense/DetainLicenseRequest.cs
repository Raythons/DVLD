using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Command.DetainLicense
{
    public class DetainLicenseRequest: IRequest<Result<DetainLicenseResponse>>
    {
        public int LicenseId { get; set; }
        public DateTime DetainDate { get;  } = DateTime.Now;
        public float FineFees { get; set; }
        public int CreatedByUserId { get; set; }

        
        public DetainLicenseRequest(
            int licenseId,
            float fineFees,
            int createdByUserId)
        {
            LicenseId = licenseId;
            FineFees = fineFees;
            CreatedByUserId = createdByUserId;
        }

       
    }
}
