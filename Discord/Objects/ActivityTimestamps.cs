using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class ActivityTimestamps
    {
        [JsonProperty(PropertyName = "start")]
        public Optional<int> Start;
        
        [JsonProperty(PropertyName = "end")]
        public Optional<int> End;
    }
}