using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Ban
    {
        [JsonProperty(PropertyName = "reason")]
        public string Reason;
        
        [JsonProperty(PropertyName = "user")]
        public User User;
    }
}