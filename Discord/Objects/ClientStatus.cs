using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class ClientStatus
    {
        [JsonProperty(PropertyName = "desktop")]
        public Optional<string> Desktop;
        
        [JsonProperty(PropertyName = "mobile")]
        public Optional<string> Mobile;
        
        [JsonProperty(PropertyName = "web")]
        public Optional<string> Web;
    }
}