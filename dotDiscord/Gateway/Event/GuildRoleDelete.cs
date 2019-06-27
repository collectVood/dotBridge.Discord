using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class GuildRoleDelete
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;

        [JsonProperty(PropertyName = "role_id")]
        public string Role;
    }
}