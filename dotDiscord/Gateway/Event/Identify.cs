using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class Identify
    {
        [JsonProperty(PropertyName = "token")]
        public string Key;
        
        [JsonProperty(PropertyName = "properties")]
        public PropertiesData Properties = new PropertiesData();
        
        [JsonProperty(PropertyName = "compress")]
        public bool? Compress = false;
        
        [JsonProperty(PropertyName = "large_threshold")]
        public int LargeThreshold = 50;
        
        // TODO: Presence

        public class PropertiesData
        {
            [JsonProperty(PropertyName = "$os")]
            public const string OS = "DotDiscord";
            
            [JsonProperty(PropertyName = "$browser")]
            public const string Browser = "DotDiscord";
            
            [JsonProperty(PropertyName = "$device")]
            public const string Device = "DotDiscord";
        }
    }
}