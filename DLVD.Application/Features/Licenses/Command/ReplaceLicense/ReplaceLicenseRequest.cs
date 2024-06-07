using DLVD.App.Features.Applications.Command.CreateApplication;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System.Text.Json.Serialization;

namespace DLVD.App.Features.Licenses.Command.ReplaceLicense
{
    public class ReplaceLicenseRequest : IRequest<Result<ReplaceLicenseResponse>>
    {
        [JsonIgnore]
        public CreateApplicationCommand CreateApplicationCommand { get; } = new CreateApplicationCommand();
        public int PreviousLicenseId { get; set; }
        public DateTime IssueDate { get; set; } = DateTime.Now;
        [JsonIgnore]
        public DateTime ExpirationDate { get; set; }
        public int DriverId { get; set; }

        [JsonIgnore]
        public int CreatedByApplicationId { get; set; }
        public float ApplicationFees { get; set; }
        public int LicenseFees { get; set; }
        public int CreatedByUserId { get; set; }
        public string IssueReason { get; set; }
        public string Notes { get; set; }
        public int ApplicationTypeId { get; set; }
        public int PersonId { get; set; }
        public int LicenseClassId { get; set; }
        public bool IsActive { get; } = true;

        public ReplaceLicenseRequest(
         int previousLicenseId,
         DateTime issueDate,
         DateTime expirationDate,
         int driverId,
         int createdByApplicationId,
         float applicationFees,
         int licenseFees,
         int createdByUserId,
         string issueReason,
         string notes,
         int applicationTypeId,
         int personId,
         int licenseClassId
          )
        {
            CreateApplicationCommand.CreatedByUserId = createdByUserId;
            CreateApplicationCommand.ApplicationTypeId = applicationTypeId;
            CreateApplicationCommand.PersonId = personId;
            CreateApplicationCommand.Status = EnStatus.Completed;
            CreateApplicationCommand.PaidFees = applicationFees;


            PreviousLicenseId = previousLicenseId;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            DriverId = driverId;
            CreatedByApplicationId = createdByApplicationId;
            ApplicationFees = applicationFees;
            LicenseFees = licenseFees;
            CreatedByUserId = createdByUserId;
            IssueReason = issueReason;
            Notes = notes;
            ApplicationTypeId = applicationTypeId;
            PersonId = personId;
            LicenseClassId = licenseClassId;
        }
    }
}
