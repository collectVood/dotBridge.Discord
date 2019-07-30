using Newtonsoft.Json;


namespace dotBridge.Discord.Objects
{
    public class VoiceRegion
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "name")]
        public string Name;

        [JsonProperty(PropertyName = "vip")]
        public bool Vip;

        [JsonProperty(PropertyName = "optimal")]
        public bool Optimal;

        [JsonProperty(PropertyName = "deprecated")]
        public bool Deprecated;

        [JsonProperty(PropertyName = "custom")]
        public bool Custom;
    }
}
