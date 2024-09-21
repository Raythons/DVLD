using DVLD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DLVD.App.Features.Common.Converters
{
    public class EnReplacementTypeConverter : JsonConverter<EnReplacementType>
    {
        public override EnReplacementType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (Enum.TryParse(reader.GetString(), out EnReplacementType status))
            {
                return status;
            }
            return default;
        }

        public override void Write(Utf8JsonWriter writer, EnReplacementType value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
