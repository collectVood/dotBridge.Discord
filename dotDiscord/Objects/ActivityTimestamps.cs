using Newtonsoft.Json;

namespace DotDiscord.Objects
{
    public class ActivityTimestamps
    {
        [JsonProperty(PropertyName = "start")]
        public int? Start;
        
        [JsonProperty(PropertyName = "end")]
        public int? End;
    }
}