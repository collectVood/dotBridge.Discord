using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildMemberChunk
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: Guild members array
    }
}