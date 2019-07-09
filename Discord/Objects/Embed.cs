using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Embed
    {
        [JsonProperty(PropertyName = "title")]
        public Optional<string> Title;
        
        [JsonProperty(PropertyName = "type")]
        public Optional<string> Type;
        
        [JsonProperty(PropertyName = "description")]
        public Optional<string> Description;
        
        [JsonProperty(PropertyName = "url")]
        public Optional<string> Url;
        
        [JsonProperty(PropertyName = "timestamp")]
        public Optional<string> Timestamp;
        
        [JsonProperty(PropertyName = "color")]
        public Optional<int> Color;
        
        // TODO: Embed footer
        
        // TODO: Embed image
        
        // TODO: Embed thumbnail
        
        // TODO: Embed video
        
        // TODO: Embed provider
        
        // TODO: Embed author
        
        // TODO: Array of embed field
    }
}