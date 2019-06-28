using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class Resume
    {
        [JsonProperty(PropertyName = "token")]
        public string Key;

        [JsonProperty(PropertyName = "session_id")]
        public string Session;

        [JsonProperty(PropertyName = "seq")]
        public int Sequence;
    }
}