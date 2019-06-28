using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class MessageDeleteBulk
    {
        [JsonProperty(PropertyName = "ids")]
        public string[] Messages;

        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;

        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
    }
}