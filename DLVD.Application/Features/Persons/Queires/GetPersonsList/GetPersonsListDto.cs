using DLVD.App.Features.Common.Converters;
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Queires.GetPersonsList
{
    public class GetPersonsListDto
    {
        
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        [JsonConverter (typeof (EnGednerJsonConverter)) ]
        public EnGender Gender { get; set; }

    }
}
