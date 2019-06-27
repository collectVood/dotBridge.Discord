using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class MessageReactionRemoveAll
    {
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
        
        [JsonProperty(PropertyName = "message_id")]
        public string Message;
        
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
    }
}