using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class ActivityTimestamps
    {
        [JsonProperty(PropertyName = "start")]
        public int? Start;
        
        [JsonProperty(PropertyName = "end")]
        public int? End;
    }
}