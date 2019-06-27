using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class GuildMemberRemove
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: User object
    }
}