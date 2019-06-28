using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class WebhooksUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
    }
}