using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class VoiceServerUpdate
    {
        [JsonProperty(PropertyName = "token")]
        public string Token;

        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;

        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint;
    }
}