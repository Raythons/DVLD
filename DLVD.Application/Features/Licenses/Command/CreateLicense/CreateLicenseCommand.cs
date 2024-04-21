using FluentResults;
using MediatR;
using System.Text.Json.Serialization;


namespace DLVD.App.Features.Licenses.Command.CreateLicense
{
    public class CreateLicenseCommand: IRequest<Result<bool>>
    {
        
        public int ApplicationId { get; set; }  
        public int LocalDrivingLicenseApplicationId { get; set; }
        public int DriverId { get; set; }
        public int LicenseClassId { get; set; }
        public DateTime IssueDate { get; } = DateTime.Now;
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; } = true;
        public string IssueReason { get; set; } = string.Empty;
        public int CreatedByUserId { get; set; }
    }
}
