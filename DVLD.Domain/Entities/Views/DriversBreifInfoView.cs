using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DVLD.Domain.Entities.Views
{
    public class DriversBreifInfoView
    {

        public int DriverId { get; set; }
        public int PersonId { get; set; }
        public string FullName { get; set; }
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime CreatedAt { get; set; }
        public int NumberOfActiveLicenses { get; set; }
        public DriversBreifInfoView() { }
    }
    public class DateJsonConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader,
            Type typeToConvert, JsonSerializerOptions options)
        {
            if (Enum.TryParse(reader.GetString(), out DateTime time))
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
