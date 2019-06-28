using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildEmojisUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: Emojis array
    }
}