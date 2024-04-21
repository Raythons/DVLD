using FluentResults;
using MediatR;


namespace DLVD.App.Features.LocalDrivingLicense.Command.CreateLocalDrivvingLicense
{
    public class CreateLocalDrivingLicenseCommand: IRequest<Result<int>>
    {

        public int ApplicationId { get; set; }
        public int LicenseClassId { get; set; }
        public CreateLocalDrivingLicenseCommand(
            int applicationId,
            int licenseClassId)
        {
            ApplicationId = applicationId;
            LicenseClassId = licenseClassId;
        }

        

    }
}
