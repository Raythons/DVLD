using DLVD.App.Features.Applications.Command.CreateApplication;
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System.Text.Json.Serialization;


namespace DLVD.App.Features.Licenses.Command.ReleaseLicense
{
    public  class ReleaseLicenseRequest : IRequest<Result<int>>
    {
        public int LicenseId { get; set; }
        [JsonIgnore]
        public int ApplicationId { get; set; }
        [JsonIgnore]
        public int DriverId { get; set; }
        public float ApplicationFees { get; set; }
        public float ApplicationTypeId { get; set; }
        [JsonIgnore]
        public DateTime CreatedAt { get; set; } 
        [JsonIgnore]
        public EnStatus EnStatus { get; } = EnStatus.Completed;
        [JsonIgnore]
        public int CreatedByUserId { get; set; }
        [JsonIgnore]
        public int PersonId { get; set; }

        public ReleaseLicenseRequest() { }
        public ReleaseLicenseRequest(
            int applicationTypeId,
            float applicationFees)
        {
            ApplicationFees = applicationFees;
            ApplicationTypeId = applicationTypeId;
        }
    }
}
