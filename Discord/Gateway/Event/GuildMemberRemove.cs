using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildMemberRemove
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: User object
    }
}