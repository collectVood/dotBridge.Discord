using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class ActivityParty
    {
        [JsonProperty(PropertyName = "id")]
        public Optional<string> Party;

        [JsonProperty(PropertyName = "size")]
        public Optional<int[]> Size;
    }
}