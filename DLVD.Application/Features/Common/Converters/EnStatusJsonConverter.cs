using DVLD.Domain.Enums;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace DLVD.App.Features.Common.Converters
{
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
