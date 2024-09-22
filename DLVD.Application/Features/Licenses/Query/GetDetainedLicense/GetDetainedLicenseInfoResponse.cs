

using DLVD.App.Features.Common.Converters;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DLVD.App.Features.Licenses.Query.GetDetainedLicense
{
    public class GetDetainedLicenseInfoResponse
    {

        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime DetainDate { get; set; }
        public string CreatedBy { get; set; } 
        public float FineFees { get; set; }
    }
}
