using DLVD.App.Features.Applications.Command.CreateApplication;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.InternationalDrivvingLicenses.Command.CreateInternationalDrivvingLicense
{
    public   class CreateInternationalDrivvingLicenseRequest :IRequest<Result<bool>>
    {
        public CreateApplicationCommand CreateApplicationCommand { get; set; }
        public int ApplicationId { get; set; }
        public int IssueUsingLocalDrivingLicenseId { get; set; }
        public int DriverId { get; set; }
        public DateTime IssueDate { get; } = DateTime.Now;
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get;  } = true;
        public int CreatedByUserId { get; set; } 



        public CreateInternationalDrivvingLicenseRequest(
            int issueUsingLocalDrivingLicenseId,
            int driverId,
            int applicationId,
            CreateApplicationCommand createApplicationCommand)
        {
            IssueUsingLocalDrivingLicenseId = issueUsingLocalDrivingLicenseId;
            DriverId = driverId;
            ApplicationId = applicationId;
            CreateApplicationCommand = createApplicationCommand;
            CreatedByUserId = CreateApplicationCommand.CreatedByUserId;
        }

    }
}
