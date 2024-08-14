using DLVD.App.Features.Common.Converters;
using DLVD.App.Features.Common.SharedDtos;
using DLVD.App.Features.Persons.Queires.GetPersonDetails;
using DLVD.App.Features.Users.Queires.GetUserQuery;
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DLVD.App.Features.Applications.Queries.GetApplication
{
    public class GetApplicationDto
    { 
        public int Id { get; set; }
        public string  FullName { get; set; }

        [JsonConverter(typeof(EnStatusJsonConverter))]
        public EnStatus Status {  get; set; }

        public string ApplicationTypeTitle { get; set; }

        [JsonConverter(typeof(EnDateJsonConverter))]
        public DateTime CreatedAt { set; get; }
        [JsonConverter(typeof(EnDateJsonConverter))]
        public DateTime LastStatusDate { set; get; }
        public float PaidFees { set; get; }
        public string CreatedByUser { get; set; }
    }
}
