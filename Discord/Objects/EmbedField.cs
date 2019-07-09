using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class EmbedField
    {
        [JsonProperty(PropertyName = "name")]
        public string Name;
        
        [JsonProperty(PropertyName = "name")]
        public string Value;

        [JsonProperty(PropertyName = "inline")]
        public Optional<bool> Inline;
    }
}