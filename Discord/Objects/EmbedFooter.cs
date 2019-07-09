using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class EmbedFooter
    {
        [JsonProperty(PropertyName = "text")]
        public string Text;

        [JsonProperty(PropertyName = "icon_url")]
        public Optional<string> IconUrl;

        [JsonProperty(PropertyName = "proxy_icon_url")]
        public Optional<string> ProxyIconUrl;
    }
}