using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Emoji
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;
        
        [JsonProperty(PropertyName = "name")]
        public string Name;
        
        // TODO: Array of role id
        
        // TODO: User

        [JsonProperty(PropertyName = "require_colons")]
        public Optional<bool> RequireColons;

        [JsonProperty(PropertyName = "managed")]
        public Optional<bool> Managed;

        [JsonProperty(PropertyName = "animated")]
        public Optional<bool> Animated;
    }
}