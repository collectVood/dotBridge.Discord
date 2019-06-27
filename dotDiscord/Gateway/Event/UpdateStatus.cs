using DotDiscord.Objects;
using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class UpdateStatus
    {
        [JsonProperty(PropertyName = "since")]
        public int? Since;
        
        // TODO: Activity

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