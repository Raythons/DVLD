using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Licenses.Command.CreateLicense
{
    public struct StHandleApplicationCreation
    {
        public int ApplicationTypeId;
        public float PaidFees;
        public int PersonId;
        public int CreatedByUserId;
        public DateTime CreatedDate = DateTime.Now;
        public DateTime LastStatusDate = DateTime.Now;
        public EnStatus Status = EnStatus.Completed;

        public StHandleApplicationCreation(int applicationTypeId, float paidFees, int personId, int createdByUserId)
        {
            ApplicationTypeId = applicationTypeId;
            PaidFees = paidFees;
            PersonId = personId;
            CreatedByUserId = createdByUserId;
        }
    }
}
