using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class EmbedAuthor
    {
        [JsonProperty(PropertyName = "name")]
        public Optional<string> Name;
        
        [JsonProperty(PropertyName = "url")]
        public Optional<string> Url;
        
        [JsonProperty(PropertyName = "icon_url")]
        public Optional<string> IconUrl;
        
        [JsonProperty(PropertyName = "proxy_icon_url")]
        public Optional<string> ProxyIconUrl;
    }
}