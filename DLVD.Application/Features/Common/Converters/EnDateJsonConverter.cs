using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DLVD.App.Features.Common.Converters
{
    public class EnDateJsonConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader,
            Type typeToConvert, JsonSerializerOptions options)
        {
            if (Enum.TryParse(reader.GetString(), out  DateTime time))
            {
                return time;
            }
            return default;
        }

        public override void Write(Utf8JsonWriter writer,
            DateTime value, JsonSerializerOptions options)
        {
            //var newDate = value.ToUniversalTime();
            writer.WriteStringValue(value.ToString("yyyy/MM/dd"));
        }
    }
}
