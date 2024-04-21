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

namespace DLVD.App.Features.Applications.Queries.GetApplicationsList
{
    public class GetApplicationListDto
    {
        
        public int Id { get; set; }
        public string FullName { get; set; }

        [JsonConverter(typeof(EnStatusJsonConverter))]
        public EnStatus Status {  get; set; }
        //public ApplicationType ApplicationType { get; set; }
        public DateTime CreatedAt { set; get; }


    }
}
