using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Overwrite
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "type")]
        public string Type;

        [JsonProperty(PropertyName = "allow")]
        public int Allow;

        [JsonProperty(PropertyName = "deny")]
        public int Deny;
    }
}