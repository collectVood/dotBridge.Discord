using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class AuditLogChange
    {
        [JsonProperty(PropertyName = "new_value")]
        public object NewValueRaw;

        [JsonProperty(PropertyName = "old_value")]
        public object OldValueRaw;

        [JsonProperty(PropertyName = "key")]
        public string Key;
    }
}