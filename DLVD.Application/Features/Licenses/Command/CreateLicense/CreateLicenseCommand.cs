using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System.Text.Json.Serialization;


namespace DLVD.App.Features.Licenses.Command.CreateLicense
{
    public class CreateLicenseCommand: IRequest<Result<bool>>
    {
        public int ApplicationTypeId { get; set; }
        public int LocalDrivingLicenseApplicationId { get; set; }
        [JsonIgnore]
        public int LicenseClassId { get; set; }
        [JsonIgnore]

        public int ApplicationId { get; set; }
        [JsonIgnore]

        public int PersonId { get; set; }
        [JsonIgnore]

        public int DriverId { get; set; } = -1;
        public DateTime IssueDate { get; } = DateTime.Now;
        [JsonIgnore]

        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        [JsonIgnore]

        public bool IsActive { get; set; } = true;
        public string IssueReason { get; set; } = string.Empty;
        [JsonIgnore]

        public int CreatedByUserId { get; set; } = -1;
        public CreateLicenseCommand() { }

        public CreateLicenseCommand(int applicationTypeId,
            int localDrivingLicenseApplicationId, string notes, 
            string issueReason, int paidFees)
        {
            ApplicationTypeId = applicationTypeId;
            LocalDrivingLicenseApplicationId = localDrivingLicenseApplicationId;
            Notes = notes;
            PaidFees = paidFees;
            IssueReason = issueReason;
        }

    }
}
