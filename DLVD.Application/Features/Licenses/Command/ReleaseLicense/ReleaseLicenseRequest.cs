using DLVD.App.Features.Applications.Command.CreateApplication;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System.Text.Json.Serialization;


namespace DLVD.App.Features.Licenses.Command.ReleaseLicense
{
    public  class ReleaseLicenseRequest : IRequest<Result<int>>
    {
        [JsonIgnore]
        public CreateApplicationCommand CreateApplicationCommand { get; set; }
        public int LicenseId { get; set; }
        public float FineFees { get; set; }

        public ReleaseLicenseRequest(
            int createdByUserId,
            int applicationTypeId,
            float fineFees,
            float paidFees)
        {
            CreateApplicationCommand.CreatedByUserId = createdByUserId;
            CreateApplicationCommand.ApplicationTypeId = applicationTypeId;
            CreateApplicationCommand.Status = EnStatus.Completed;
            CreateApplicationCommand.PaidFees = paidFees;
            FineFees = fineFees;
        }

       
     
    }
}
