using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class EmbedThumbnail
    {
        [JsonProperty(PropertyName = "url")]
        public Optional<string> Url;
        
        [JsonProperty(PropertyName = "proxy_url")]
        public Optional<string> ProxyUrl;
        
        [JsonProperty(PropertyName = "height")]
        public Optional<int> Height;
        
        [JsonProperty(PropertyName = "width")]
        public Optional<int> Width;
    }
}