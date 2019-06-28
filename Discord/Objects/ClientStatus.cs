using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class ClientStatus
    {
        [JsonProperty(PropertyName = "desktop")]
        public string Desktop;
        
        [JsonProperty(PropertyName = "mobile")]
        public string Mobile;
        
        [JsonProperty(PropertyName = "web")]
        public string Web;
    }
}