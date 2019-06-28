using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildRoleCreate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: Role object
    }
}