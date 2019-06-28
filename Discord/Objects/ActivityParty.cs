using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class ActivityParty
    {
        [JsonProperty(PropertyName = "id")]
        public string Party;

        [JsonProperty(PropertyName = "size")]
        public int[] Size;
    }
}