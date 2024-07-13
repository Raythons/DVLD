using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        [JsonConverter(typeof (EnStatusJsonConverter))]
        public EnStatus Status { get; set; }
    }

    public class EnStatusJsonConverter : JsonConverter<EnStatus>
    {
        public override EnStatus Read(ref Utf8JsonReader reader,
                Type typeToConvert, JsonSerializerOptions options)
        {
            if (Enum.TryParse(reader.GetString(), out EnStatus status))
            {
                return status;
            }
            return default;
        }

        public override void Write(Utf8JsonWriter writer, EnStatus value,
            JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
