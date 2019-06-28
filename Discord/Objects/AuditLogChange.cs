using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class AuditLogChange
    {
        [JsonProperty(PropertyName = "new_value")]
        public Optional<object> NewValueRaw;

        [JsonProperty(PropertyName = "old_value")]
        public Optional<object> OldValueRaw;

        [JsonProperty(PropertyName = "key")]
        public string Key;
    }
}