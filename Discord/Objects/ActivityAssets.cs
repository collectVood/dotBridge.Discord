using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class ActivityAssets
    {
        [JsonProperty(PropertyName = "large_image")]
        public Optional<string> LargeImage;
        
        [JsonProperty(PropertyName = "large_text")]
        public Optional<string> LargeText;
        
        [JsonProperty(PropertyName = "small_image")]
        public Optional<string> SmallImage;
        
        [JsonProperty(PropertyName = "small_text")]
        public Optional<string> SmallText;
    }
}