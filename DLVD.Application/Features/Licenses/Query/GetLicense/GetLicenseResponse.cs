using DLVD.App.Features.Common.Converters;
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DLVD.App.Features.Licenses.Query.GetLicense
{

    public class GetLicenseResponse
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public string LicenseClass { get; set; }
        public string Name { get; set; }

        [JsonConverter(typeof(EnGednerJsonConverter))]
        public EnGender Gender { get; set; }
        public string NationalNo { get; set; }
        [JsonConverter(typeof (DateJsonConverter))]
        public DateTime DateOfBirth { get; set; }
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime IssueDate { get; set; }
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public string IssueReason { get; set; }
        public int CreatedByUserId { get; set; }
        public string ImagePath { get; set; }
    }
}
