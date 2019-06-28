using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildMemberUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;

        [JsonProperty(PropertyName = "roles")]
        public string[] Roles;
        
        // TODO: User object

        [JsonProperty(PropertyName = "nick")]
        public string Nickname;
    }
}