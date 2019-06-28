using dotBridge.Discord.Objects;
using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class UpdateStatus
    {
        [JsonProperty(PropertyName = "since")]
        public int? Since;
        
        [JsonProperty(PropertyName = "game")]
        public Activity Activity;

        [JsonProperty(PropertyName = "status")]
        public string StatusRaw;

        [JsonProperty(PropertyName = "afk")]
        public bool AFK;

        [JsonIgnore]
        public StatusType Status
        {
            set => StatusRaw = value.String();
        }
    }
}