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
    public class EnGednerJsonConvertercs : JsonConverter<EnGender>
    {
        public override EnGender Read(ref Utf8JsonReader reader,
            Type typeToConvert, JsonSerializerOptions options)
        {
            if (Enum.TryParse(reader.GetString(), out EnGender gender))
            {
                return gender;
            }
            return default;
        }

        public override void Write(Utf8JsonWriter writer,
            EnGender value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
