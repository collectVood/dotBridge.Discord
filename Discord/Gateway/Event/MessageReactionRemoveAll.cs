using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class MessageReactionRemoveAll
    {
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
        
        [JsonProperty(PropertyName = "message_id")]
        public string Message;
        
        [JsonProperty(PropertyName = "guild_id")]
        public Optional<string> Guild;
    }
}