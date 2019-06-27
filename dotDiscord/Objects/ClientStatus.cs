using Newtonsoft.Json;

namespace DotDiscord.Objects
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