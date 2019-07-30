using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Reaction
    {
        [JsonProperty(PropertyName = "count")]
        public int Count;
        
        [JsonProperty(PropertyName = "me")]
        public bool Me;

        [JsonProperty(PropertyName = "emoji")]
        public Emoji Emoji;
    }
}