using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class GuildRoleCreate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: Role object
    }
}