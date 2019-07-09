using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class IntegrationAccount
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "name")]
        public string Name;
    }
}