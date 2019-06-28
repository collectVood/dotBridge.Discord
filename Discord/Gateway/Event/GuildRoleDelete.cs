using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildRoleDelete
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;

        [JsonProperty(PropertyName = "role_id")]
        public string Role;
    }
}