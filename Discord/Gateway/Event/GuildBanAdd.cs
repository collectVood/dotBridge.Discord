using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildBanAdd
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: User object
    }
}