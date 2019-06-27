using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class GuildMemberChunk
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: Guild members array
    }
}