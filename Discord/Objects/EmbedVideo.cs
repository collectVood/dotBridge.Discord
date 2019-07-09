using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class EmbedVideo
    {
        [JsonProperty(PropertyName = "url")]
        public Optional<string> Url;
        
        [JsonProperty(PropertyName = "height")]
        public Optional<int> Height;
        
        [JsonProperty(PropertyName = "width")]
        public Optional<int> Width;
    }
}