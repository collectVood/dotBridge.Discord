using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class MessageReactionRemove
    {
        [JsonProperty(PropertyName = "user_id")]
        public string User;
        
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
        
        [JsonProperty(PropertyName = "message_id")]
        public string Message;
        
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: Emoji object
    }
}