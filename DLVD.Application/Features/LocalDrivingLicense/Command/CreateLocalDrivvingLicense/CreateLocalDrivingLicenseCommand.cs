using DVLD.Domain.Enums;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.LocalDrivingLicense.Command.CreateLocalDrivvingLicense
{
    public class CreateLocalDrivingLicenseCommand: IRequest<Result<int>>
    {

        public int ApplicationId { get; set; }
        public int LicenseClassId { get; set; }
        public int PersonId { get; set; }
        public EnStatus Status { get; set; } = EnStatus.New;
        public DateTime CreatedAt { get; } = DateTime.Now;
        public DateTime LastStatus { get; } = DateTime.Now;
        public float PaidFees { get; set; } 
        public int CreatedByUserId { get; set; }
        public int ApplicationTypeId { get; set; }
        public CreateLocalDrivingLicenseCommand(
            int licenseClassId,
            int personId,
            float paidFees,
            int createdByUserId, int applicationTypeId)

        {
            LicenseClassId = licenseClassId;
            PersonId = personId;
            PaidFees = paidFees;
            CreatedByUserId = createdByUserId;
            ApplicationTypeId = applicationTypeId;
        }
    }
}
