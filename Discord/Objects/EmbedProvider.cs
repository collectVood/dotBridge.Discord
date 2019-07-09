using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class EmbedProvider
    {
        [JsonProperty(PropertyName = "name")]
        public Optional<string> Name;
        
        [JsonProperty(PropertyName = "url")]
        public Optional<string> Url;
    }
}