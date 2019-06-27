using Newtonsoft.Json;

namespace DotDiscord.Objects
{
    public class ActivityParty
    {
        [JsonProperty(PropertyName = "id")]
        public string Party;

        [JsonProperty(PropertyName = "size")]
        public int[] Size;
    }
}