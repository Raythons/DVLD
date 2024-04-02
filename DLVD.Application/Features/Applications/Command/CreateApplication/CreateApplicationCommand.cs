using DVLD.Domain.Enums;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Applications.Command.CreateApplication
{
    public class CreateApplicationCommand : IRequest<Result<int>>
    {
        
        public int PersonId { get; set; }
        public int LicenseClassId { get; set; }
        public EnStatus Status { get;  } = EnStatus.New;
        public DateTime CreatedAt { get; } = DateTime.Now;
        public DateTime LastStatus { get; } = DateTime.Now;
        public float PaidFees { get;} = 15.5f;
        public int CreatedByUserId { get; set; } 
        public int ApplicationTypeId { get; set; }
        public CreateApplicationCommand() { }

        public CreateApplicationCommand(
            int personId,
            int createdByUserId,
            int applicationTypeId,
            int licenseClassId)
        {
            PersonId = personId;
            CreatedByUserId = createdByUserId;
            ApplicationTypeId = applicationTypeId;
            LicenseClassId = licenseClassId;
        }
    }
   
    
}
