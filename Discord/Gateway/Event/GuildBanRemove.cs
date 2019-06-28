using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildBanRemove
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: User object
    }
}