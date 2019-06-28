using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class TypingStart
    {
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
        
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        [JsonProperty(PropertyName = "user_id")]
        public string User;
        
        [JsonProperty(PropertyName = "timestamp")]
        public int Timestamp;
    }
}