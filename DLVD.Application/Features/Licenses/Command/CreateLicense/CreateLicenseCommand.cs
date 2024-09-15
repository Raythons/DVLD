using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Command.CreateLicense
{
    public class CreateLicenseCommand: IRequest<Result<bool>>
    {
        public CreateLicenseCommand(int applicationTypeId,
            int localDrivingLicenseApplicationId,
            int personId, int driverId, DateTime issueDate, 
            string notes, bool isActive, 
            string issueReason, int paidFees)
        {
            ApplicationTypeId = applicationTypeId;
            LocalDrivingLicenseApplicationId = localDrivingLicenseApplicationId;
            PersonId = personId;
            DriverId = driverId;
            IssueDate = issueDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
        }

        public int ApplicationTypeId { get; set; }  
        public int LocalDrivingLicenseApplicationId { get; set; }
        public int LicenseClassId { get; set; }
        public int ApplicationId { get; set; }
        public int PersonId { get;set; }
        public int DriverId { get; set; } = -1;
        public DateTime IssueDate { get; } = DateTime.Now;
        public DateTime ExpirationDate { get; set; } 
        public string Notes { get; set; }
        public int PaidFees { get; set; }
        public bool IsActive { get; set; } = true;
        public string IssueReason { get; set; } = string.Empty;
        public int CreatedByUserId { get; set; } = -1;
    }
}
