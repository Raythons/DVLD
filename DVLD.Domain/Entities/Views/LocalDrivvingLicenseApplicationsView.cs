using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Domain.Entities.Views
{
    public class LocalDrivvingLicenseApplicationsView
    {
        public int  Id { get; set; }
        public string ClassName { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; } 
        public int PassedTestCount { get; set; }
        public EnStatus Status { get; set; }
    }
}
