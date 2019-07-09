using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class MessageApplication
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "cover_image")]
        public Optional<string> CoverImage;

        [JsonProperty(PropertyName = "cover_image")]
        public string Description;

        [JsonProperty(PropertyName = "cover_image")]
        public string Icon;

        [JsonProperty(PropertyName = "cover_image")]
        public string Name;
    }
}