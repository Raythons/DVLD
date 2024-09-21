using DLVD.App.Features.Applications.Command.CreateApplication;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System.Text.Json.Serialization;

namespace DLVD.App.Features.Licenses.Command.RenewLicense
{
    public class RenewLicenseRerquest : IRequest<Result<RenewLicenseResponse>>
    {

        public int PreviousLicenseId { get; set; }
        [JsonIgnore]
        public int ApplicationId { get; set; }

        public DateTime IssueDate { get; set; } = DateTime.Now;
        [JsonIgnore]
        public DateTime ExpirationDate { get; set; }
        public int DriverId { get; set; }
        public float ApplicationFees { get; set; }
        public int LicenseFees { get; set; }
        [JsonIgnore]
        public int CreatedByUserId { get; set; }
        [JsonIgnore]
        public string IssueReason { get; set; } = "Re-new";
        public string Notes { get; set; } = "";
        public int ApplicationTypeId { get; set; }
        [JsonIgnore]
        public int PersonId { get; set; }
        [JsonIgnore]
        public int LicenseClassId { get; set; }
        [JsonIgnore]
        public bool IsActive { get; } = true;
        [JsonIgnore]
        public EnStatus EnStatus { get; set; } = EnStatus.Completed;

        public RenewLicenseRerquest(
           int previousLicenseId,
           float applicationFees,
           int licenseFees,
           string notes,
           int applicationTypeId
            )
        {
            PreviousLicenseId = previousLicenseId;
            ApplicationFees = applicationFees;
            LicenseFees = licenseFees;
            Notes = notes;
            ApplicationTypeId = applicationTypeId;
        }



        //public RenewLicenseRerquest() { }

    }
}

// Mapping It Inside Better Than Sendnig The Data

