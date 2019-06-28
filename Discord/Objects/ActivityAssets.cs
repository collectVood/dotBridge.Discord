using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class ActivityAssets
    {
        [JsonProperty(PropertyName = "large_image")]
        public string LargeImage;
        
        [JsonProperty(PropertyName = "large_text")]
        public string LargeText;
        
        [JsonProperty(PropertyName = "small_image")]
        public string SmallImage;
        
        [JsonProperty(PropertyName = "small_text")]
        public string SmallText;
    }
}