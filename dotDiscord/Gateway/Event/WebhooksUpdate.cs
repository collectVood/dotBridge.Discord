using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class WebhooksUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
    }
}