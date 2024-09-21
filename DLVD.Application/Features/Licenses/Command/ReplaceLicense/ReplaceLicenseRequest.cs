using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Common.Converters;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System.Text.Json.Serialization;

namespace DLVD.App.Features.Licenses.Command.ReplaceLicense
{
    public class ReplaceLicenseRequest : IRequest<Result<ReplaceLicenseResponse>>
    {
        [JsonIgnore]
        public int ApplicationId { get; set; }
        public int PreviousLicenseId { get; set; }
        public DateTime IssueDate { get; set; } = DateTime.Now;
        [JsonIgnore]
        public DateTime ExpirationDate { get; set; }
        [JsonIgnore]
        public int DriverId { get; set; }
        public float ApplicationFees { get; set; }
        [JsonIgnore]
        public int CreatedByUserId { get; set; }
        public string IssueReason { get; set; }
        public string Notes { get; set; }
        public int ApplicationTypeId { get; set; }
        [JsonIgnore]
        public int PersonId { get; set; }
        [JsonIgnore]
        public int LicenseClassId { get; set; }
        [JsonConverter(typeof(EnReplacementTypeConverter))]
        public EnReplacementType ReplacementType { get; set; } 
        public bool IsActive { get; } = true;

        public ReplaceLicenseRequest(
         int previousLicenseId,
         float applicationFees,
         string issueReason,
         int applicationTypeId
          )
        {
            PreviousLicenseId = previousLicenseId;
            ApplicationFees = applicationFees;
            IssueReason = issueReason;
            ApplicationTypeId = applicationTypeId;
        }
    }
}
