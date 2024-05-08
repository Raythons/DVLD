using DLVD.App.Features.Applications.Command.CreateApplication;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System.Text.Json.Serialization;

namespace DLVD.App.Features.Licenses.Command.RenewLicense
{
    public class RenewLicenseRerquest : IRequest<Result<RenewLicenseResponse>>
    {
        [JsonIgnore]
        public CreateApplicationCommand CreateApplicationCommand { get; } = new CreateApplicationCommand();
        public int PreviousLicenseId { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public DateTime IssueDate { get; set; } = DateTime.Now;
        public DateTime ExpirationTime { get; set; }

        [JsonIgnore]
        public int CreatedByApplicationId { get; set; } 
        public float ApplicationFees { get; set; }
        public int LicenseFees { get; set; }
        public int CreatedByUserId { get; set; }
        public string IssueReason { get; set; }
        public string Notes { get; set; }
        public int ApplicationTypeId { get; set; }
        public int PersonId { get; set; }

        public RenewLicenseRerquest() { }
        public RenewLicenseRerquest(
                int previousLicenseId,
                DateTime applicationDate,
                DateTime issueDate,
                DateTime expirationTime,
                int applicationFees,
                int licenseFees,
                int createdByUserId,
                int  applicationTypeId,
                string issueReason,
                string notes)
        {
            // Mapping It Inside Better Than Sendnig The Data
            //CreateApplicationCommand = creaSteApplicationCommand;
            CreateApplicationCommand.CreatedByUserId = createdByUserId;
            CreateApplicationCommand.ApplicationTypeId = applicationTypeId;
            CreateApplicationCommand.Status = EnStatus.Completed;
            CreateApplicationCommand.PaidFees = applicationFees;
            
            ApplicationTypeId = applicationTypeId;
            PreviousLicenseId = previousLicenseId;
            ApplicationDate = applicationDate;
            IssueDate = issueDate;
            ExpirationTime = expirationTime;
            ApplicationFees = applicationFees;
            LicenseFees = licenseFees;
            CreatedByUserId = createdByUserId;
            IssueReason = issueReason;
            Notes = notes;
        }
    }
}
