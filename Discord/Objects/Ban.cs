using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Ban
    {
        [JsonProperty(PropertyName = "reason")]
        public string Reason;
        
        // TODO: User
    }
}