using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class MessageDelete
    {
        [JsonProperty(PropertyName = "id")]
        public string Message;
        
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
        
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
    }
}