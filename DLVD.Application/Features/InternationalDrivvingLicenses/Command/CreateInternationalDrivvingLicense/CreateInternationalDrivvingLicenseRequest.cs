using DLVD.App.Features.Applications.Command.CreateApplication;
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System.Text.Json.Serialization;


namespace DLVD.App.Features.InternationalDrivvingLicenses.Command.CreateInternationalDrivvingLicense
{
    public   class CreateInternationalDrivvingLicenseRequest :IRequest<Result<bool>>
    {
        public CreateInternationalDrivvingLicenseRequest(
            int applicationTypeId, float applicationTypeFees, int licenseId,int driverId)
        {
            ApplicationTypeId = applicationTypeId;
            ApplicationTypeFees = applicationTypeFees;
            LicenseId = licenseId;
            DriverId = driverId;
        }

        public int ApplicationTypeId { get; set; }
        [JsonIgnore]
        public int ApplicationId { get; set; }
        public float ApplicationTypeFees { get; set; }
        public int LicenseId { get; set; }
        [JsonIgnore]
        public EnStatus Status { get; } = EnStatus.Completed;
        public int DriverId { get; set; }
        [JsonIgnore]
        public DateTime IssueDate { get; } = DateTime.Now;
        public DateTime ExpirationDate { get; set; }
        [JsonIgnore]
        public bool IsActive { get;  } = true;
        [JsonIgnore]
        public int CreatedByUserId { get; set; } 

      

    }
}
