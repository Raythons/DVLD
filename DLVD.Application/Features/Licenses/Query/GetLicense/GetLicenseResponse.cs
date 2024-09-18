using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Licenses.Query.GetLicense
{

    public class GetLicenseResponse
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public string LicenseClass { get; set; }
        public string Name { get; set; }
        public EnGender Gedner { get; set; }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public string IssueReason { get; set; }
        public int CreatedByUserId { get; set; }
        public string ImagePath { get; set; }
    }
}
