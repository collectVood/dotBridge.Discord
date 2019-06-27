using Newtonsoft.Json;

namespace DotDiscord.Objects
{
    public class SessionStartLimit
    {
        [JsonProperty(PropertyName = "total")]
        public int Total;
        
        [JsonProperty(PropertyName = "remaining")]
        public int Remaining;
        
        [JsonProperty(PropertyName = "reset_after")]
        public int ResetAfter;
    }
}