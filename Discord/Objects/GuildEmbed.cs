using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class GuildEmbed
    {
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled;
        
        [JsonProperty(PropertyName = "channel_id")]
        public string ChannelID;
    }
}